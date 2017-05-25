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
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Entities;
namespace Zh.BLL.Define.Contracts
{
    public partial interface IWeiXinQRCodePromotionActivityAccountPointsHistoryService : IBaseService<WeiXinQRCodePromotionActivityAccountPointsHistoryDto, WeiXin_QRCodePromotionActivityAccountPointsHistory>
    {
        /// <summary>
        /// 获取用户积分记录
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="openId">微信用户OpenId</param>
        /// <returns></returns>
        GenericPageResult<WeiXinQRCodePromotionActivityAccountPointsHistoryDto> Find(Guid webApplicationId, string openId, int pageIndex = 1, int pageSize = 10);
    }
}