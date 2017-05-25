/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件 
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
using Zh.WeiXin.BLL.API.Entities;
namespace Zh.BLL.Define.Entities
{
    #region WeiXinQRCodePromotionActivityAccountPointsHistoryDto

    /// <summary>
    /// 微信参加二维码推广活动用户积分使用历史信息表
    /// WeiXinQRCodePromotionActivityAccountPointsHistoryDto data view model for mapped table 'WeiXin_QRCodePromotionActivityAccountPointsHistory'.
    /// </summary>
    public partial class WeiXinQRCodePromotionActivityAccountPointsHistoryDto
    {
        /// <summary>
        /// ExchangeMoney 字符串f2显示
        /// </summary>
        public string ExchangeMoneyDisplay
        {
            get
            {
                if (this.ExchangeMoney.HasValue == false) return "0.00";
                return this.ExchangeMoney.Value.ToString("f2");
            }
        }
        /// <summary>
        /// 加载活动用户信息
        /// </summary>
        /// <returns></returns>
        public WeiXinQRCodePromotionActivityAccountDto LoadAccount()
        {
            var svcContext = new ServiceContexts.ServiceContext();
            this.WeiXinQRCodePromotionActivityAccountDto = svcContext.IWeiXinQRCodePromotionActivityAccountService.FindById(this.WeiXinQRCodePromotionActivityAccountId);
            return this.WeiXinQRCodePromotionActivityAccountDto;
        }
        /// <summary>
        /// 扫码关注微信账号信息
        /// </summary>
        public WeiXinAccount ScanWeiXinAccount { get; set; }
        /// <summary>
        /// 加载扫码关注微信账号信息
        /// </summary>
        /// <returns></returns>
        public WeiXinAccount LoadScanWeiXinAccount()
        {
            var account = LoadAccount();
            var svcContext = new ServiceContexts.ServiceContext();
            this.ScanWeiXinAccount = svcContext.IWeiXinQRCodePromotionActivityAccountService.GetWeiXinAccount(account.WebApplicationId, this.MemberOpenId);
            return this.ScanWeiXinAccount;
        }
        /// <summary>
        /// 扫码关注微信账号头像Url
        /// </summary>
        public string ScanWeiXinAccountHeaderImageUrl
        {
            get
            {
                if (this.ScanWeiXinAccount == null) return string.Empty;
                return this.ScanWeiXinAccount.headimgurl;
            }
        }
        /// <summary>
        /// 创建时间yyyy-MM-dd HH:mm:ss显示方式
        /// </summary>
        public string CreatedDateDisplay
        {
            get
            {
                return this.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
    #endregion
}
