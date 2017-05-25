using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;
using Zh.Framework.Entities;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信二维码API
    /// </summary>
    public interface IQRCodeAPI
    {
        /// <summary>
        /// 创建临时带场景参数,获取二维码Ticket结果数据结构Post参数
        /// </summary>
        /// <param name="accessToken">公众号的全局唯一票据,access_token</param>
        /// <param name="expireSeconds">该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为30秒。</param>
        /// <param name="sceneId">场景值ID，临时二维码时为32位非0整型</param>
        /// <returns>创建微信临时二维码Post参数</returns>
        QRCodePostDataDto CreateTemporaryQRCodePostDataDto(string accessToken, int? expireSeconds, int sceneId);
        /// <summary>
        /// 创建永久带场景参数获取二维码Ticket结果数据结构Post参数
        /// </summary>
        /// <param name="accessToken">公众号的全局唯一票据,access_token</param>
        /// <param name="sceneId">场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1--100000）</param>
        /// <param name="sceneStr">场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段</param>  
        /// <returns>创建微信永久二维码Post参数</returns>
        QRCodePostDataDto CreateForeverQRCodePostDataDto(string accessToken, int sceneId, string sceneStr);
        /// <summary>
        /// 创建带场景参数,获取二维码Ticket结果数据结构Post参数
        /// </summary>
        /// <param name="accessToken">公众号的全局唯一票据,access_token</param>
        /// <param name="expireSeconds">该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为30秒。</param>
        /// <param name="qrCodeEnum">二维码类型，QR_SCENE为临时,QR_LIMIT_SCENE为永久,QR_LIMIT_STR_SCENE为永久的字符串参数值</param>
        /// <param name="sceneId">场景值ID，临时二维码时为32位非0整型，永久二维码时最大值为100000（目前参数只支持1--100000）</param>
        /// <param name="sceneStr">场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段</param>
        /// <returns>创建微信二维码Post参数</returns>
        QRCodePostDataDto CreateQRCodePostDataDto(string accessToken, int? expireSeconds, QRCodeEnum qrCodeEnum, int sceneId, string sceneStr);
        /// <summary>
        /// 根据GetQRCodeTicketResultDto - 获取二维码Ticket结果数据结构对象,创建二维码图片
        /// </summary>
        /// <param name="getQRCodeTicketResultDto">获取二维码Ticket结果数据结构</param>
        /// <param name="imageWidth">二维码图片宽度</param>
        /// <param name="imageHeight">二维码图片高度</param>
        /// <returns>二维码图片</returns>
        Image CreateQRCodeImageByQRCodePostDataDto(GetQRCodeTicketResultDto getQRCodeTicketResultDto, int imageWidth, int imageHeight);
        /// <summary>
        /// 获取微信二维码Ticket
        /// </summary>
        /// <param name="accessToken">accessToken</param>
        /// <param name="qrCodePostDataDto">获取二维码Ticket结果数据结构,CreateQRCodePostDataDto,CreateForeverQRCodePostDataDto,
        /// CreateTemporaryQRCodePostDataDto方法返回值</param>
        /// <returns>二维码Ticket</returns>
        GetQRCodeTicketResultDto GetQRCodeTicket(string accessToken, QRCodePostDataDto qrCodePostDataDto);
        /// <summary>
        /// 获取微信二维码图片Url
        /// </summary>
        /// <param name="getQRCodeTicketResultDto">微信二维码Ticket数据结构,GetQRCodeTicket方法返回值</param> 
        /// <returns>微信二维码图片Url</returns>
        string GetWeiXinQRCodeImageUrl(GetQRCodeTicketResultDto getQRCodeTicketResultDto);
        /// <summary>
        /// 获取微信二维码图片Url
        /// </summary>
        /// <param name="getQRCodeTicketResultDto">微信二维码Ticket数据结构的Ticket字段,GetQRCodeTicket方法返回值中的Ticket字段</param> 
        /// <returns>微信二维码图片Url</returns>
        string GetWeiXinQRCodeImageUrl(string qrCodeTicket);
    }
}
