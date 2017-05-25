using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.BLL.Define.Contracts;
using Zh.Framework.Tools;
using Zh.DAL.Base.Define.Query;
using Zh.Web.Controllers.Base;
using Zh.Framework.Exceptions;
using Zh.BLL.Define.Entities;

namespace Zh.Web.Controllers.Areas.WebAPI.Controllers
{
    public class WeiXinQRCodePromotionActivityAccountController : BaseController
    {
        IWeiXinQRCodePromotionActivityAccountService IWeiXinQRCodePromotionActivityAccountService = ToolFactory.BLLIoc.Get<IWeiXinQRCodePromotionActivityAccountService>();
        public ActionResult List(Guid webApplicationId, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                if (webApplicationId == Guid.Empty)
                {
                    throw new BaseException("webApplicationId不能为空");
                }
                var orderBys = OrderByHelper.Create().Desc("OpenId");
                var where = Where.Create().Eq("WebApplicationId", webApplicationId);
                var listResult = this.IWeiXinQRCodePromotionActivityAccountService.Page(orderBys, where, pageIndex, pageSize);
                foreach (var item in listResult.Data)
                {
                    item.LoadWeiXinAccount();
                }
                return this.JsonSuccessGenericPageExecResult(listResult);
            }
            catch (BaseException ex)
            {
                return this.JsonFailureGenericPageExecResult(ex);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
