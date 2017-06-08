using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Entities;
using Zh.Framework.Exceptions;

namespace Zh.Web.Mvc.Framework.Filters
{
    /// <summary>
    /// 异常日志拦截器
    /// </summary>
    public class WebApiReturnJsonExceptionAttribute : HandleErrorAttribute
    {
        /// <summary>
        /// 是否只过滤由Ajax引起的异常
        /// </summary>
        /// <returns></returns>
        public bool IsNotOnlyFilterAjaxInvokeException { get; set; } = true;

        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception == null) return;
            if (filterContext.ExceptionHandled) return;
            if (filterContext.HttpContext.Request.IsAjaxRequest() ||
                "application/json".Equals(filterContext.HttpContext.Request.ContentType, StringComparison.OrdinalIgnoreCase) ||
                this.IsNotOnlyFilterAjaxInvokeException)
            {
                filterContext.ExceptionHandled = true;
                filterContext.Result = new JsonResult()
                {
                    Data = this.BuildResponse(filterContext),
                    ContentEncoding = Encoding.UTF8,
                    ContentType = this.GetContentType(),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }


        /// <summary>
        /// 创建返回的json
        /// </summary>
        /// <param name="filterContext"></param>
        /// <returns></returns>
        public object BuildResponse(ExceptionContext filterContext)
        {
            if (filterContext.Exception is ConstraintsValidationException)
            {
                var ex = (ConstraintsValidationException)filterContext.Exception;
                return new GenericApiResult<Dictionary<string, List<string>>>()
                {
                    code = ex.Code,
                    message = ex.Message,
                    data = ex.Errors,
                    success = false
                };
            }
            else if (filterContext.Exception is ValidationException)
            {
                var ex = (ValidationException)filterContext.Exception;
                return new GenericApiResult<string>()
                {
                    code = ex.Code,
                    message = ex.Message,
                    success = false
                };
            }

            else
            {
                return new GenericApiResult<string>()
                {
                    code = int.MinValue,
                    message = "业务异常,请稍候再试",
                    success = false,
                };
            }
        }
        /// <summary>
        /// 返回json的content-type
        /// </summary>
        /// <returns></returns>
        public string GetContentType()
        {
            return "application/json";
        }

    }
}