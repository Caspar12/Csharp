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
using Zh.Framework.Exceptions;

namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class WeiXinMerchantBIllNoService : GenericContextService<WeiXinMerchantBIllNoDto, WeiXin_MerchantBIllNo>, IWeiXinMerchantBIllNoService
    {

        public WeiXinMerchantBIllNoDto CreateOrGetNextBillNo(Guid webApplicationId, DateTime? pBillCreatedDate = null)
        {
            if (webApplicationId == Guid.Empty)
            {
                throw new BaseException("webApplicationId参数不能为空");
            }
            var webApp = this.ServiceContext.ICWXWeiXinApplicationService.FindById(webApplicationId);
            if (webApp == null)
            {
                throw new BaseException(string.Format("ID({0})的微信关联数据为空", webApplicationId));
            }
            var billCreatedDate = DateTime.Now.Date;
            if (pBillCreatedDate.HasValue)
            {
                billCreatedDate = pBillCreatedDate.Value;
            }
            var previousBillNo = this.GetPreviousBillNo(webApplicationId, billCreatedDate);
            if (previousBillNo == null)
            {
                previousBillNo = new WeiXinMerchantBIllNoDto()
                {
                    WebApplicationId = webApplicationId,
                    NumeroSign = 1,
                    BillCreatedDate = billCreatedDate
                };
                this.Insert(previousBillNo);
            }
            var nextBillNo = new WeiXinMerchantBIllNoDto()
            {
                WebApplicationId = webApplicationId,
                NumeroSign = previousBillNo.NumeroSign + 1,
                BillCreatedDate = billCreatedDate
            };
            this.Insert(nextBillNo);
            return nextBillNo;
        }

        public WeiXinMerchantBIllNoDto GetPreviousBillNo(Guid webApplicationId, DateTime? pBillCreatedDate = null)
        {
            var billCreatedDate = DateTime.Now.Date;
            if (pBillCreatedDate.HasValue)
            {
                billCreatedDate = pBillCreatedDate.Value;
            }
            var maxNumeroSign = this.Max<int>("NumeroSign",
                Where.Create()
                .Eq("WebApplicationId", webApplicationId)
                .Eq("BillCreatedDate", billCreatedDate)
            );
            var model = this.FirstOrDefault(Where.Create()
                    .Eq("WebApplicationId", webApplicationId)
                    .Eq("BillCreatedDate", billCreatedDate)
                    .Eq("NumeroSign", maxNumeroSign)
            );
            return model;
        }

        public string CreateOrGetNextWeiXinMerchantBillNo(Guid webApplicationId, DateTime? pBillCreatedDate = null)
        {
            var billCreatedDate = DateTime.Now.Date;
            if (pBillCreatedDate.HasValue)
            {
                billCreatedDate = pBillCreatedDate.Value;
            }
            var merchantBillNo = this.CreateOrGetNextBillNo(webApplicationId, billCreatedDate);
            var billNumberoSign = string.Format("{0:d10}", merchantBillNo.NumeroSign);
            var webApp = this.ServiceContext.ICWXWeiXinApplicationService.FindById(webApplicationId);
            var weiXinMerchantBillNo = string.Format("{0}{1}{2}",
                 webApp.MerchantId,
                 billCreatedDate.ToString("yyyyMMdd"),
                 billNumberoSign);
            return weiXinMerchantBillNo;
        }

        public string GetPreviousWeiXinMerchantBillNo(Guid webApplicationId, DateTime? pBillCreatedDate = null)
        {
            var billCreatedDate = DateTime.Now.Date;
            if (pBillCreatedDate.HasValue)
            {
                billCreatedDate = pBillCreatedDate.Value;
            }
            var merchantBillNo = this.GetPreviousBillNo(webApplicationId, billCreatedDate);
            if (merchantBillNo == null) return string.Empty;
            var billNumberoSign = string.Format("{0:d10}", merchantBillNo.NumeroSign);
            var webApp = this.ServiceContext.ICWXWeiXinApplicationService.FindById(webApplicationId);
            var weiXinMerchantBillNo = string.Format("{0}{1}{2}",
                 webApp.MerchantId,
                 billCreatedDate.ToString("yyyyMMdd"),
                 billNumberoSign);
            return weiXinMerchantBillNo;
        }
    }
}
