using System;
using System.Collections.Generic;
using System.Text;
using Zh.BLL.Define.Contracts;
using Zh.BLL.Base.Define;
using Zh.Framework.Exceptions;
using Zh.WeiXin.BLL.API;
using Zh.DAL.Base.Define.Query;
using Zh.Framework.Cache;
using Zh.BLL.Imp.WeiXin.Caches;
using Zh.Framework.Entities;
using Zh.BLL.Define.Entities;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define;
using Zh.WeiXin.BLL.API.Entities;
using Zh.DAL.Base.Define.Entities;

namespace Zh.BLL.Imp.WeiXin
{
    /// <summary>
    /// 微信二维码推广活动逻辑集合
    /// </summary>
    public class WeiXinQRCodePromotionActivityAccountService :
        GenericContextService<WeiXinQRCodePromotionActivityAccountDto, WeiXin_QRCodePromotionActivityAccount>,
        IWeiXinQRCodePromotionActivityAccountService
    {
        /// <summary>
        /// 注入二维码图片宽度
        /// </summary>
        public int QRCodeImageWidth { get; set; }
        /// <summary>
        /// 注入二维码图片高度度
        /// </summary>
        public int QRCodeImageHeight { get; set; }
        /// <summary>
        /// 注入微信API
        /// </summary>
        WeiXinAPIContext _WeiXinAPIContext { get; set; }
        public string CreateOrGetQRCodePromotionActivityImageUrl(Guid webApplicationId, string openId)
        {
            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }
            var weiXinQRCodeAccount = this.CreateOrGetAccount(webApplicationId, openId);

            var resultData = this.GetQRCodePromotionActivityImageUrl(webApplicationId, openId);
            if (!string.IsNullOrEmpty(resultData))
            {
                return resultData;
            }

            WeiXinQRCodeDto weiXinQRCode = null;
            if (weiXinQRCodeAccount.QRCodeId.HasValue)
            {
                var weiXinQRCodeResult = this.ServiceContext.IWeiXinQRCodeService.FindById(weiXinQRCodeAccount.QRCodeId.Value);
                if (weiXinQRCodeResult != null)
                {
                    weiXinQRCode = weiXinQRCodeResult;
                }
            }
            var accessToken = this.ServiceContext.ICWXWeiXinApplicationService.GetAccessToken(webApplicationId);
            var config = this.ServiceContext.IWeiXinQRCodePromotionActivityConfigService.CreateOrGet(webApplicationId);
            if (config == null)
            {
                throw new BaseException(string.Format("ID({0})微信关联程序配置数据读取失败", webApplicationId));
            }
            var sceneId = (int)this.ServiceContext.IComMaxIdService.CreateNext(webApplicationId);
            var createTemporaryQRCodePostDataDtoResult = _WeiXinAPIContext
            .IQRCodeAPI.CreateTemporaryQRCodePostDataDto(accessToken, config.NewTemporaryQRCodeImageExpireInSeconds, sceneId);
            var getQRCodeTicketResult = _WeiXinAPIContext.IQRCodeAPI.GetQRCodeTicket(accessToken, createTemporaryQRCodePostDataDtoResult);
            resultData = _WeiXinAPIContext.IQRCodeAPI.GetWeiXinQRCodeImageUrl(getQRCodeTicketResult);
            var isNewWeiXinQRCode = false;
            if (weiXinQRCode == null)
            {
                isNewWeiXinQRCode = true;
                weiXinQRCode = new WeiXinQRCodeDto()
                {
                    ID = Guid.NewGuid()
                };
            }
            weiXinQRCode.ActionName = config.QRCodeActionName;
            weiXinQRCode.ExpireSeconds = config.IsTemporary ? config.NewTemporaryQRCodeImageExpireInSeconds : -1;
            weiXinQRCode.Ticket = getQRCodeTicketResult.ticket;
            weiXinQRCode.ID = Guid.NewGuid();
            weiXinQRCode.CreatedDate = DateTime.Now;
            weiXinQRCode.QRCodeUrl = getQRCodeTicketResult.url;
            weiXinQRCode.SceneId = sceneId;
            weiXinQRCode.SceneStr = null;
            weiXinQRCode.WebApplicationId = webApplicationId;

            this.ServiceContext.IWeiXinQRCodeService.InsertOrUpdate(weiXinQRCode);
            weiXinQRCodeAccount.QRCodeId = weiXinQRCode.ID;
            if (isNewWeiXinQRCode) this.Update(weiXinQRCodeAccount);
            return resultData;

        }

        public WeiXinQRCodePromotionActivityAccountDto CreateOrGetAccount(Guid webApplicationId, string openId)
        {
            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("webApplicationId不能为空");
            }
            var where = Where.Create()
                .Eq("WebApplicationId", webApplicationId)
                .Eq("OpenId", openId);
            var modelResult = this.FirstOrDefault(where);
            if (modelResult == null)
            {
                modelResult = new WeiXinQRCodePromotionActivityAccountDto()
                {
                    ID = Guid.NewGuid(),
                    OpenId = openId,
                    Points = 0,
                    WebApplicationId = webApplicationId
                };
                this.Insert(modelResult);
                return modelResult;
            }
            return modelResult;
        }
        public WeiXinQRCodePromotionActivityAccountDto FindAccount(Guid webApplicationId, string openId)
        {

            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("webApplicationId不能为空");
            }
            var where = Where.Create()
                .Eq("WebApplicationId", webApplicationId)
                .Eq("OpenId", openId);
            var model = this.FirstOrDefault(where);

            return model;

        }


        public WeiXinAccount GetWeiXinAccount(Guid webApplicationId, string openId)
        {
            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("webApplicationId不能为空");
            }
            var accessToken = this.ServiceContext.ICWXWeiXinApplicationService.GetAccessToken(webApplicationId);
            return _WeiXinAPIContext.IAccountAPI.GetBasicAccountInfo(accessToken, openId);
        }


        /// <summary>
        /// 获取用户二维码推广活动二维码图片地址
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns></returns>
        public string GetQRCodePromotionActivityImageUrl(Guid webApplicationId, string openId)
        {
            if (this.IValidatorTool.IsEmpty(openId))
            {
                throw new BaseException("openId不能为空");
            }
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }
            var weiXinQRCodeAccount = this.FirstOrDefault(
                Where.Create()
                .Eq("WebApplicationId", webApplicationId)
                .Eq("OpenId", openId)
            );
            if (weiXinQRCodeAccount == null)
            {
                return string.Empty;
            }
            var resultData = string.Empty;
            WeiXinQRCodeDto weiXinQRCode = null;
            if (weiXinQRCodeAccount.QRCodeId.HasValue)
            {
                var weiXinQRCodeResult = this.ServiceContext.IWeiXinQRCodeService.FindById(weiXinQRCodeAccount.QRCodeId.Value);
                if (weiXinQRCodeResult != null)
                {
                    weiXinQRCode = weiXinQRCodeResult;
                }
            }
            if (weiXinQRCode != null && weiXinQRCode.IsExpire == false)
            {
                resultData = _WeiXinAPIContext.IQRCodeAPI.GetWeiXinQRCodeImageUrl(weiXinQRCode.Ticket);
            }
            return resultData;
        }
        /// <summary>
        /// 获取推广活动用户信息
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="sceneId">微信关注扫码场景Id</param>
        /// <returns></returns>
        public WeiXinQRCodePromotionActivityAccountDto FindAccountBySceneId(Guid webApplicationId, int sceneId)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }

            var qrCode = ServiceContext.IWeiXinQRCodeService.FirstOrDefault(
                 Where.Create()
                 .Eq("WebApplicationId", webApplicationId)
                 .Eq("SceneId", sceneId)
            );
            if (qrCode == null) return null;

            var weiXinQRCodeAccount = this.FirstOrDefault(
                  Where.Create()
                  .Eq("WebApplicationId", webApplicationId)
                  .Eq("QRCodeId", qrCode.ID)
            );
            return weiXinQRCodeAccount;
        }
    }
}
