using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.BLL.Define.Contracts;
using Zh.Framework.Tools;
using Zh.Framework.Exceptions;
using Zh.DAL.Base.Define.Query;
using Zh.Web.Controllers.Base;

namespace Zh.Web.Controllers.Areas.WebAPI.Controllers
{
    public class WeiXinQRCodePromotionActivityAccountPointsHistoryController : BaseController
    {
        IWeiXinQRCodePromotionActivityAccountPointsHistoryService IWeiXinQRCodePromotionActivityAccountPointsHistoryService =
            ToolFactory.BLLIoc.Get<IWeiXinQRCodePromotionActivityAccountPointsHistoryService>();

        public ActionResult List(Guid weiXinQRCodePromotionActivityAccountId, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                if (weiXinQRCodePromotionActivityAccountId == Guid.Empty)
                {
                    throw new BaseException("WeiXinQRCodePromotionActivityAccountId不能为空");
                }
                var orderBys = OrderByHelper.Create().Desc("CreatedDate");
                var where = Where.Create().Eq("WeiXinQRCodePromotionActivityAccountId", weiXinQRCodePromotionActivityAccountId);
                var listResult = this.IWeiXinQRCodePromotionActivityAccountPointsHistoryService
                    .Page(orderBys, where, pageIndex, pageSize);
                
                return this.JsonSuccessGenericPageExecResult(listResult);
            }
            catch (Exception ex)
            {
                return this.JsonFailureGenericPageExecResult(ex);
            }
        }
    }
}
