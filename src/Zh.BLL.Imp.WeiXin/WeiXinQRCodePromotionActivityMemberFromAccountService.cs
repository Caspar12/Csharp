/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using Zh.BLL.Define;
using Zh.BLL.Define.Contracts;
using Zh.Framework.Exceptions;

namespace Zh.BLL.Imp.WeiXin
{
    public partial class WeiXinQRCodePromotionActivityMemberFromAccountService : GenericContextService<WeiXinQRCodePromotionActivityMemberFromAccountDto, WeiXin_QRCodePromotionActivityMemberFromAccount>,
        IWeiXinQRCodePromotionActivityMemberFromAccountService
    {
        /// <summary>
        /// 二维码推广活动扫码增加积分
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="sceneId">场景Id</param>
        /// <param name="scanOpenId">扫码微信用户OpenId</param> 
        public void CreateSceneFollowRecord(Guid webApplicationId, int sceneId, string scanOpenId)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("微信关联程序Id不能为空");
            }
            if (sceneId == 0)
            {
                throw new BaseException("SceneId场景Id错误");
            }
            if (string.IsNullOrEmpty(scanOpenId))
            {
                throw new BaseException("扫码微信用户OpenId不能为空");
            }
            var account = ServiceContext.IWeiXinQRCodePromotionActivityAccountService.FindAccountBySceneId(webApplicationId, sceneId);
            if (account == null)
            {
                throw new BaseException(string.Format("微信关联程序Id({1}),场景Id({0}),推广用户数据为空", sceneId, webApplicationId));
            }
            var weiXinAccount = account.LoadWeiXinAccount();
            if (weiXinAccount == null)
            {
                throw new BaseException(string.Format("微信关联程序Id({1}),场景Id({0}),推广用户获取微信用户数据为空", sceneId, webApplicationId));
            }
            if (weiXinAccount.IsSubscribe == false)
            {
                throw new BaseException(string.Format("微信关联程序Id({1}),场景Id({0}),推广用户没有关注微信公众号", sceneId, webApplicationId));
            }
            var config = ServiceContext.IWeiXinQRCodePromotionActivityConfigService.CreateOrGet(webApplicationId);
            if (config.GetFollowPulicWeiXinAccountPointsType == Entities.GetFollowPulicWeiXinAccountPointsEnum.NewUnique)
            {
                var count = this.ServiceContext.IWeiXinQRCodePromotionActivityMemberFromAccountService.Count<int>("ID",
                     Where.Create()
                     .Eq("WebApplicationId", webApplicationId)
                     .Eq("MemberOpenId", scanOpenId)
                );
                if (count > 0)
                {
                    throw new BaseException(string.Format("微信关联程序Id({1}),场景Id({0}),OpenId({2})的微信用户已有关注记录", sceneId, webApplicationId, scanOpenId));
                }
            }
            if (config.IsFollowPublicWeiXinAccountHasPoints == false)
            {
                return;
            }
            var sceneWeiXinAccount = ServiceContext.IWeiXinQRCodePromotionActivityAccountService.GetWeiXinAccount(webApplicationId, scanOpenId);
            WeiXinQRCodePromotionActivityMemberFromAccountDto memberFromAccount = new WeiXinQRCodePromotionActivityMemberFromAccountDto()
            {
                ActivityOpenId = account.OpenId,
                MemberOpenId = scanOpenId,
                WebApplicationId = webApplicationId,
                WeiXinQRCodePromotionActivityAccountId = account.ID,
                ID = Guid.NewGuid()
            };
            var beforePoints = account.Points;
            var afterPoints = account.Points + config.FollowPoints;
            var history = new WeiXinQRCodePromotionActivityAccountPointsHistoryDto()
            {
                ID = Guid.NewGuid(),
                UsePoints = config.FollowPoints * -1,
                ExchangeMoney = null,
                Remark = string.Format("{0}关注公众号", sceneWeiXinAccount.nickname),
                CreatedDate = DateTime.Now,
                BeforePoints = beforePoints,
                WeiXinQRCodePromotionActivityAccountId = account.ID,
                MemberOpenId = scanOpenId,
                AfterPoints = afterPoints
            };
            account.Points += config.FollowPoints;
            this.ServiceContext.IWeiXinQRCodePromotionActivityAccountService.Update(account);
            this.Insert(memberFromAccount);
            this.ServiceContext.IWeiXinQRCodePromotionActivityAccountPointsHistoryService.Insert(history);

        }
    }
}
