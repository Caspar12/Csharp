using System;
using System.Collections.Generic;
using System.Text;
using Zh.WeiXin.BLL.API.Entities;
using Zh.Framework.Helpers;
using System.Drawing;
using Zh.Framework.Entities;
using Zh.Net.Http;
using Zh.Framework.Tools;
using Zh.WeiXin.BLL.Helpers;
using Zh.Framework.Tools.QRCodeTool;

namespace Zh.WeiXin.BLL.API.Imp
{
    public class QRCodeAPI : IQRCodeAPI
    {
        /// <summary>
        /// 二维码帮助类,必须注入属性
        /// </summary>
        public IQRCode IQRCode { get; set; }
        /// <summary>
        /// 二维码类型,QR_SCENE为临时
        /// </summary>
        public static string QR_SCENE = "QR_SCENE";
        /// <summary>
        /// 二维码类型,QR_LIMIT_SCENE为永久
        /// </summary>
        public static string QR_LIMIT_SCENE = "QR_LIMIT_STR_SCENE";
        /// <summary>
        /// 微信创建二维码接口Url,https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}
        /// </summary>
        public static string WEIXIN_CREATE_QR_URL = "https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token={0}";
        /// <summary>
        /// 微信二维码图片获取地址
        /// </summary>
        public static string WEIXIN_QRCODE_IMAGE_URL = "https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket={0}";
        private GenericExecResult<object> IsSceneStrValid(string sceneStr)
        {
            if (string.IsNullOrEmpty(sceneStr) || sceneStr.Length == 0 || sceneStr.Length > 64)
            {
                return new Framework.Entities.GenericExecResult<object>()
                {
                    Success = false,
                    Message = "场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段"
                };
            }
            return new Framework.Entities.GenericExecResult<object>()
            {
                Success = true
            };
        }


        private Framework.Entities.GenericExecResult<object> IsSceneIdValid(Entities.QRCodeEnum qrCodeEnum, int sceneId)
        {
            if (qrCodeEnum == QRCodeEnum.Forever)
            {
                if ((1 <= sceneId && sceneId <= 100000) == false)
                {
                    return new Framework.Entities.GenericExecResult<object>()
                    {
                        Success = false,
                        Message = "永久二维码参数scene_id,目前只支持1--100000"
                    };
                }
                return new Framework.Entities.GenericExecResult<object>()
                {
                    Success = true
                };
            }
            else
            {
                if (sceneId == 0)
                {
                    return new Framework.Entities.GenericExecResult<object>()
                    {
                        Success = false,
                        Message = "临时二维码,scene_id只支持32位非0整型"
                    };
                }
                return new Framework.Entities.GenericExecResult<object>()
                {
                    Success = true
                };
            }
        }
        private GenericExecResult<object> IsExpireSecondsValid(int? expireSeconds)
        {
            if (expireSeconds.HasValue && (expireSeconds.Value <= 0 || expireSeconds.Value > 2592000))
            {
                return new Framework.Entities.GenericExecResult<object>()
                {
                    Success = false,
                    Message = "二维码有效时间错误,最小不少0秒,最大不超过2592000秒（即30天）,此字段如果不填,则默认有效期为30秒."
                };
            }
            return new Framework.Entities.GenericExecResult<object>()
            {
                Success = true
            };
        }
        private string GetQRSceneEnumStr(QRCodeEnum qrCodeEnum)
        {
            if (qrCodeEnum == QRCodeEnum.Forever)
            {
                return QR_LIMIT_SCENE;
            }
            else if (qrCodeEnum == QRCodeEnum.Temporary)
            {
                return QR_SCENE;
            }
            else
            {
                throw new Exception("未知道二维码类型");
            }
        }
        public QRCodePostDataDto CreateTemporaryQRCodePostDataDto(string accessToken, int? expireSeconds, int sceneId)
        {
            return CreateQRCodePostDataDto(accessToken, expireSeconds, QRCodeEnum.Temporary, sceneId, null);
        }

        public QRCodePostDataDto CreateForeverQRCodePostDataDto(
            string accessToken, int sceneId, string sceneStr)
        {
            return CreateQRCodePostDataDto(accessToken, null, QRCodeEnum.Forever, sceneId, sceneStr);
        }

        public QRCodePostDataDto CreateQRCodePostDataDto(string accessToken, int? expireSeconds,
            Entities.QRCodeEnum qrCodeEnum, int sceneId, string sceneStr)
        {
            var qrCodePostDataDto = new QRCodePostDataDto();
            IsExpireSecondsValid(expireSeconds).IfFailureThrowException();

            IsSceneIdValid(qrCodeEnum, sceneId).IfFailureThrowException();

            qrCodePostDataDto.action_name = GetQRSceneEnumStr(qrCodeEnum);
            qrCodePostDataDto.expire_seconds = expireSeconds;
            if (qrCodeEnum == QRCodeEnum.Forever)
            {
                IsSceneStrValid(sceneStr).IfFailureThrowException();

                qrCodePostDataDto.action_info = new QRCodeActionInfo()
                {
                    scene = new ForeverScene()
                    {
                        scene_id = sceneId,
                        scene_str = sceneStr
                    }
                };
            }
            else
            {
                qrCodePostDataDto.action_info = new QRCodeActionInfo()
                {
                    scene = new TemporaryScene()
                    {
                        scene_id = sceneId
                    }
                };
            }

            return qrCodePostDataDto;
        }

        public Image CreateQRCodeImageByQRCodePostDataDto(GetQRCodeTicketResultDto getQRCodeTicketResultDto,
            int imageWidth,
            int imageHeight)
        {
            var createQRImageResult = this.IQRCode.CreateQRCodeImage(getQRCodeTicketResultDto.url, imageWidth, imageHeight);
            return createQRImageResult;
        }

        public GetQRCodeTicketResultDto GetQRCodeTicket(string accessToken, QRCodePostDataDto qrCodePostDataDto)
        {
            var weiXinUrl = string.Format(WEIXIN_CREATE_QR_URL, accessToken);

            IHttpClient client = ToolFactory.BLLIoc.Get<IHttpClient>();
            var iJsonHelper = ToolFactory.CreateIJsonSerializeTool();
            var postData = iJsonHelper.SerializeToString(qrCodePostDataDto);
            var postResult = client.Post(weiXinUrl, postData);
            WeiXinHelper.IsFailureInvokeWeiXinAPIThrowException(postResult);
            var result = iJsonHelper.DeserializeFromString<GetQRCodeTicketResultDto>(postResult);
            return result;
        }
        public string GetWeiXinQRCodeImageUrl(GetQRCodeTicketResultDto getQRCodeTicketResultDto)
        {
            return GetWeiXinQRCodeImageUrl(getQRCodeTicketResultDto.ticket);
        }


        public string GetWeiXinQRCodeImageUrl(string getQRCodeTicketResultDtoTicket)
        {
            return string.Format(WEIXIN_QRCODE_IMAGE_URL, WebHelper.UrlEncode(getQRCodeTicketResultDtoTicket));
        }
    }
}
