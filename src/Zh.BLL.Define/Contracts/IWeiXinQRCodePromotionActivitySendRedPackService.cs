/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层接口契约文件 
 */
using System;
using System.Collections.Generic;
using System.Text;
using Zh.BLL.Define.Entities;

namespace Zh.BLL.Define.Contracts
{
    /// <summary>
    /// 二维码推广活动发送红包逻辑
    /// </summary>
    public interface IWeiXinQRCodePromotionActivitySendRedPackService
    {
        /// <summary>
        /// 发放现金红包
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="weiXinQRCodePromotionActivityAccountId">微信参加二维码推广活动用户Id</param>
        /// <param name="usePoints">消费积分</param>
        /// <param name="exchangeMoney">兑换金额,单位分</param>
        void CreateSendCashRedPack(Guid webApplicationId, Guid weiXinQRCodePromotionActivityAccountId, int usePoints, int exchangeMoney);
        /// <summary>
        /// 发放现金红包,查找大于等于usePoints积分的账号数据,然后消费usePoints的积分,兑换exchangeMoney分的现金红包，进行发放
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="usePoints">准备兑换的积分</param>
        /// <param name="exchangeMoney">准备兑换的现金红包</param>
        /// <returns></returns>
        CreateSendCashRedPackListResult CreateSendCashRedPack(Guid webApplicationId, int usePoints, int exchangeMoney);
    }
}
