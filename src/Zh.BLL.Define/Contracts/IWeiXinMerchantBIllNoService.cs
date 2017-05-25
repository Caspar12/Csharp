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
    public partial interface IWeiXinMerchantBIllNoService : IBaseService<WeiXinMerchantBIllNoDto, WeiXin_MerchantBIllNo>
    {
        /// <summary>
        /// 创建或获取下一位账单号
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="billCreatedDate">账单号创建日期,默认当前日期</param>
        /// <returns></returns>
        WeiXinMerchantBIllNoDto CreateOrGetNextBillNo(Guid webApplicationId, DateTime? pBillCreatedDate = null);
        /// <summary>
        /// 获取上一位账单号
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="billCreatedDate">账单号创建日期,默认当前日期</param>
        /// <returns></returns>
        WeiXinMerchantBIllNoDto GetPreviousBillNo(Guid webApplicationId, DateTime? billCreatedDate = null);
        /// <summary>
        /// 创建或获取下一位商户订单号（每个订单号必须唯一）
        /// 组成：mch_id+yyyymmdd+10位一天内不能重复的数字。
        /// 接口根据商户订单号支持重入，如出现超时可再调用。
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="billCreatedDate">账单号创建日期,默认当前日期</param>
        /// <returns></returns>
        string CreateOrGetNextWeiXinMerchantBillNo(Guid webApplicationId, DateTime? billCreatedDate = null);
        /// <summary>
        /// 获取上一位账单号
        /// </summary>
        /// <param name="webApplicationId">微信关联程序Id</param>
        /// <param name="billCreatedDate">账单号创建日期,默认当前日期</param>
        /// <returns>没有上一位账单号为string.Empty</returns>
        string GetPreviousWeiXinMerchantBillNo(Guid webApplicationId, DateTime? billCreatedDate = null);
    }
}