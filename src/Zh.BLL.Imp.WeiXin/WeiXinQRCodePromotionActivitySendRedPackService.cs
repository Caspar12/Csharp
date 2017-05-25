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
using Zh.Framework.Tools;

namespace Zh.BLL.Imp.WeiXin
{
    /// <summary>
    /// 二维码推广活动发送红包逻辑
    /// </summary>
    public class WeiXinQRCodePromotionActivitySendRedPackService : BaseContextService,
        IWeiXinQRCodePromotionActivitySendRedPackService
    {
        WeiXinAPIContext _WeiXinAPIContext;
        /// <summary>
        /// 注入微信API,不注入获取默认
        /// </summary>
        WeiXinAPIContext WeiXinAPIContext
        {
            get
            {
                if (_WeiXinAPIContext == null)
                {
                    _WeiXinAPIContext = ToolFactory.BLLIoc.Get<WeiXinAPIContext>();
                }
                return _WeiXinAPIContext;
            }
            set
            {
                _WeiXinAPIContext = value;
            }
        }
        public CreateSendCashRedPackListResult CreateSendCashRedPack(Guid webApplicationId, int usePoints, int exchangeMoney)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }
            if (usePoints <= 0)
            {
                throw new BaseException("消费积分不能少于或等于0");
            }
            if (exchangeMoney <= 0)
            {
                throw new BaseException("兑换金额不能少于或等于0");
            }
            CreateSendCashRedPackListResult dataResult = new CreateSendCashRedPackListResult();
            var preSendRedPackAccountList = this.ServiceContext.IWeiXinQRCodePromotionActivityAccountService.FindByProperties(
                 Where.Create()
                 .Eq("WebApplicationId", webApplicationId)
                 .Ge("Points", usePoints)
             );
            dataResult.TotalCount = preSendRedPackAccountList.Count;
            foreach (var account in preSendRedPackAccountList)
            {
                WeiXinAccount weiXinAccount = null;
                try
                {
                    weiXinAccount = account.LoadWeiXinAccount();
                }
                catch { }
                if (weiXinAccount == null)
                {
                    var dataResultItem = new CreateSendCashRedPackListResultItem()
                    {
                        ExchangeMoney = exchangeMoney,
                        Remark = string.Format("{0}-OpenId失败,加载微信账号信息失败,可能是没有订阅或者网络连接失败导致", account.OpenId),
                        IsSuccess = true,
                        UsePoints = usePoints,
                        WeiXinAccount = weiXinAccount,
                        OpenId = account.OpenId
                    };
                    dataResult.CreateSendCashRedPackListResultItems.Add(dataResultItem);
                    continue;
                }
                try
                {
                    CreateSendCashRedPackListResultItem dataResultItem = new CreateSendCashRedPackListResultItem()
                    {
                        ExchangeMoney = exchangeMoney,
                        Remark = string.Format("{0}-OpenId,{1},成功", account.OpenId, weiXinAccount.nickname),
                        IsSuccess = true,
                        UsePoints = usePoints,
                        WeiXinAccount = weiXinAccount,
                        OpenId = account.OpenId
                    };
                    this.ServiceContext.IWeiXinQRCodePromotionActivitySendRedPackService.CreateSendCashRedPack(webApplicationId, account.ID, usePoints, exchangeMoney);

                    dataResult.CreateSendCashRedPackListResultItems.Add(dataResultItem);
                    dataResult.SuccessCount++;
                }
                catch (Exception ex)
                {
                    var dataResultItem = new CreateSendCashRedPackListResultItem()
                    {
                        ExchangeMoney = exchangeMoney,
                        Remark = string.Format("{0}-OpenId,失败,{1}<br />{2}<br />{3}",
                            account.OpenId,
                            ex.Message + (ex.InnerException != null ? "," + ex.InnerException.Message : ""),
                            ex.Source,
                            ex.StackTrace
                        ),
                        IsSuccess = true,
                        UsePoints = usePoints,
                        WeiXinAccount = weiXinAccount,
                        OpenId = account.OpenId
                    };
                    dataResult.CreateSendCashRedPackListResultItems.Add(dataResultItem);
                }
            }
            return dataResult;
        }
        /// <summary>
        /// 发放现金红包
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="weiXinQRCodePromotionActivityAccountId">微信参加二维码推广活动用户Id</param>
        /// <param name="usePoints">消费积分</param>
        /// <param name="exchangeMoney">兑换金额,单位分</param>
        public void CreateSendCashRedPack(Guid webApplicationId, Guid weiXinQRCodePromotionActivityAccountId, int usePoints, int exchangeMoney)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("weiXinApplicationId不能为空");
            }
            if (weiXinQRCodePromotionActivityAccountId == Guid.Empty)
            {
                throw new BaseException("weiXinQRCodePromotionActivityAccountId不能为空");
            }
            if (usePoints <= 0)
            {
                throw new BaseException("消费积分不能少于或等于0");
            }
            if (exchangeMoney <= 0)
            {
                throw new BaseException("兑换金额不能少于或等于0");
            }

            var account = this.ServiceContext.IWeiXinQRCodePromotionActivityAccountService.FindById(weiXinQRCodePromotionActivityAccountId);
            if (account == null)
            {
                throw new BaseException(string.Format("ID为({0})的用户数据为空", weiXinQRCodePromotionActivityAccountId));
            }
            if (account.Points < usePoints)
            {
                throw new BaseException(string.Format("积分不够进行兑换操作"));
            }

            var weiXinAccount = account.LoadWeiXinAccount();
            if (weiXinAccount.IsSubscribe == false)
            {
                throw new BaseException(string.Format("该用户没有关注公众号"));
            }
            var webApplication = this.ServiceContext.ICWXWeiXinApplicationService.FindById(account.WebApplicationId);
            if (webApplication == null)
            {
                throw new BaseException(string.Format("ID({0})微信关联程序数据为空", account.WebApplicationId));
            }
            if (string.IsNullOrEmpty(webApplication.MerchantId))
            {
                throw new BaseException(string.Format("ID({0})微信关联程序的MerchantId商户数据为空", account.WebApplicationId));
            }
            var merchantId = webApplication.MerchantId;
            var beforePoints = account.Points;
            var afterPoints = account.Points - usePoints;
            var pointsHistory = new WeiXinQRCodePromotionActivityAccountPointsHistoryDto()
            {
                ID = Guid.NewGuid(),
                BeforePoints = account.Points,
                AfterPoints = afterPoints,
                CreatedDate = DateTime.Now,
                ExchangeMoney = exchangeMoney,
                Remark = string.Format("使用积分{0},兑换{1}元", usePoints, (((decimal)exchangeMoney) / 100).ToString("f2")),
                UsePoints = usePoints,
                WeiXinQRCodePromotionActivityAccountId = account.ID
            };
            account.Points = afterPoints;
            this.ServiceContext.IWeiXinQRCodePromotionActivityAccountPointsHistoryService.Insert(pointsHistory);
            this.ServiceContext.IWeiXinQRCodePromotionActivityAccountService.Update(account);
            var merchantBillNo = this.ServiceContext.IWeiXinMerchantBIllNoService
                .CreateOrGetNextWeiXinMerchantBillNo(webApplication.ID, DateTime.Now.Date);
            var weiXinQRCodePromotionActivityConfigService = new WeiXinQRCodePromotionActivityConfigService();
            var config = weiXinQRCodePromotionActivityConfigService.CreateOrGet(webApplication.ID);
            var iAppContext = ToolFactory.CreateIAppContext();
            var certFilePath = iAppContext.GetMapExecPath("~/apiclient_cert.p12");
            var sendRedPack = this.WeiXinAPIContext.IPayCashRedPack.SendRedPack(
                   certFilePath,
                   config.CertFilePwd,
                   webApplication.APISecretKey,
                   merchantBillNo,
                   webApplication.MerchantId,
                   webApplication.AppID,
                   config.RedPackSendName,
                   account.OpenId,
                   exchangeMoney,
                   1,
                   config.RedPackWishing,
                   config.RedPackClientIP,
                   config.RedPackActivityName,
                   config.RedPackRemark
            );
            if (sendRedPack.IsFailureReturnCode)
            {
                throw new BaseException(sendRedPack.return_msg);
            }
            if (sendRedPack.IsFailureResultCode)
            {
                throw new BaseException(sendRedPack.err_code_des);
            }
        }
    }
}
