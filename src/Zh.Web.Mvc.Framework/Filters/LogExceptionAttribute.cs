using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Exceptions;

namespace Zh.Web.Mvc.Framework.Filters
{
    /// <summary>
    /// 异常日志拦截器
    /// </summary>
    public class LogExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception == null) return;

            ILog log = log4net.LogManager.GetLogger(filterContext.Controller.ControllerContext.Controller.GetType());

            if (filterContext.Exception is ValidationException)
            {
                if (log.IsInfoEnabled)
                {
                    log.Info(filterContext.Exception);
                }
            }
            else
            {
                if (log.IsFatalEnabled)
                {
                    log.Fatal(filterContext.Exception);
                }
            }
        }
    }
}