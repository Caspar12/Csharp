/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口契约文件 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.BLL.Define.Entities;
using Zh.BLL.Base.Define;
namespace Zh.BLL.Define.Contracts
{
    public partial interface IWeiXinQRCodePromotionActivityMemberFromAccountService : IBaseService<WeiXinQRCodePromotionActivityMemberFromAccountDto, WeiXin_QRCodePromotionActivityMemberFromAccount>
    {
        /// <summary>
        /// 创建二维码推广活动扫码积分记录,并增加积分
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="sceneId">场景Id</param>
        /// <param name="scanOpenId">扫码微信用户OpenId</param>
        void CreateSceneFollowRecord(Guid webApplicationId, int sceneId, string scanOpenId);
    }
}