
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Base.Define;
using Zh.Framework.Entities;
namespace Zh.BLL.Define.Contracts
{
    /// <summary>
    /// 二维码推广活动用户逻辑
    /// </summary>
    public partial interface IWeiXinQRCodePromotionActivityAccountService : IBaseService<WeiXinQRCodePromotionActivityAccountDto, WeiXin_QRCodePromotionActivityAccount>
    {
        /// <summary>
        /// 创建或者获取用户二维码推广活动二维码图片地址
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns></returns>
        string CreateOrGetQRCodePromotionActivityImageUrl(Guid webApplicationId, string openId);
        /// <summary>
        /// 创建或者获取用户二维码推广活动二维码图片地址
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns>当有有效二维码数据,返回二维码图片Url</returns>
        string GetQRCodePromotionActivityImageUrl(Guid webApplicationId, string openId);
        /// <summary>
        /// 获取推广活动用户信息
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns></returns>
        WeiXinQRCodePromotionActivityAccountDto FindAccount(Guid webApplicationId, string openId);
        /// <summary>
        /// 获取推广活动用户信息
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="sceneId">微信关注扫码场景Id</param>
        /// <returns></returns>
        WeiXinQRCodePromotionActivityAccountDto FindAccountBySceneId(Guid webApplicationId, int sceneId);
        /// <summary>
        /// 获取微信用户基本信息
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns></returns>
        WeiXin.BLL.API.Entities.WeiXinAccount GetWeiXinAccount(Guid webApplicationId, string openId);
    }
}