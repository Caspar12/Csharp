/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件 
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using Zh.WeiXin.BLL.API.Entities;
using Zh.WeiXin.BLL.API;
using Zh.Framework.Tools;
namespace Zh.BLL.Define.Entities
{
    public partial class WeiXinQRCodePromotionActivityAccountDto
    {
        /// <summary>
        /// 加载微信二维码信息
        /// </summary>
        /// <returns></returns>
        public WeiXinQRCodeDto LoadWeiXinQRCode()
        {
            if (this.QRCodeId.HasValue)
            {
                ServiceContexts.ServiceContext svcContext = new ServiceContexts.ServiceContext();
                this.WeiXinQRCodeDto = svcContext.IWeiXinQRCodeService.FindById(this.QRCodeId.Value);
            }
            return this.WeiXinQRCodeDto;
        }
        string _WeiXinQrCodeImageUrl;
        /// <summary>
        /// 二维码图片Url
        /// </summary>
        public string WeiXinQrCodeImageUrl
        {
            get
            {
                if (this._WeiXinQrCodeImageUrl == null)
                {
                    ServiceContexts.ServiceContext svcContext = new ServiceContexts.ServiceContext();
                    _WeiXinQrCodeImageUrl = svcContext.IWeiXinQRCodePromotionActivityAccountService.GetQRCodePromotionActivityImageUrl(this.WebApplicationId, this.OpenId);
                }
                return this._WeiXinQrCodeImageUrl;
            }
        }
        /// <summary>
        /// 微信用户基本信息
        /// </summary>
        public WeiXinAccount WeiXinAccount { get; set; }
        /// <summary>
        /// 加载微信用户基本信息
        /// </summary>
        /// <returns></returns>
        public WeiXinAccount LoadWeiXinAccount()
        {
            ServiceContexts.ServiceContext svcContext = new ServiceContexts.ServiceContext();
            this.WeiXinAccount = svcContext.IWeiXinQRCodePromotionActivityAccountService.GetWeiXinAccount(this.WebApplicationId, this.OpenId);
            return this.WeiXinAccount;
        }
        /// <summary>
        /// 微信用户基本信息头像Url地址
        /// </summary>
        public string WeiXinAccountHeaderImageUrl
        {
            get
            {
                if (this.WeiXinAccount == null) return string.Empty;
                return this.WeiXinAccount.headimgurl;
            }
        }

        /// <summary>
        /// 微信用户基本信息昵称
        /// </summary>
        public string WeiXinAccountNickName
        {
            get
            {
                if (this.WeiXinAccount == null) return string.Empty;
                return this.WeiXinAccount.nickname;
            }
        }

    }
}