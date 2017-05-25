using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Tools.EntityTool;
using Zh.Framework.Tools;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Entities;

namespace Zh.Web.Controllers.Base
{
    public abstract class BaseController : Controller
    {
        IValidatorTool _IValidatorTool;
        protected IValidatorTool IValidatorTool
        {
            get
            {
                if (_IValidatorTool == null)
                {
                    _IValidatorTool = ToolFactory.CreateIValidatorTool();
                }
                return _IValidatorTool;
            }
        }
        public BaseController()
        {
            IEntityTool iEntityTool = ToolFactory.CreateIEntityTool();
            if (System.Web.HttpContext.Current.Request.QueryString.Count != 0)
            {
                var queryStringBinder = iEntityTool.CreateINVCollectionBinder(System.Web.HttpContext.Current.Request.QueryString);
                queryStringBinder.Bind<BaseController>(this);
            }
            if (System.Web.HttpContext.Current.Request.Form.Count != 0)
            {
                var formBinder = iEntityTool.CreateINVCollectionBinder(System.Web.HttpContext.Current.Request.Form);
                formBinder.Bind<BaseController>(this);
            }
        }
        public ActionResult ResponseJson(object data)
        {
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult JsonFailureGenericPageExecResult(string message = "", Exception exception = null)
        {
            if (string.IsNullOrEmpty(message) && exception != null)
            {
                message = exception.Message;
            }
            GenericExecResult<object> execResult = new GenericExecResult<object>()
            {
                Success = false,
                Message = message,
                Exception = exception,
                Data = null
            };
            return ResponseJson(execResult);
        }
        public ActionResult JsonFailureGenericPageExecResult(Exception exception = null)
        {
            return JsonFailureGenericPageExecResult("", exception);
        }

        public ActionResult JsonSuccessGenericPageExecResult<T>(GenericPageResult<T> pageResult, string message = "")
        {
            GenericExecResult<GenericPageResult<T>> execResult = new GenericExecResult<GenericPageResult<T>>()
            {
                Success = true,
                Message = message,
                Data = pageResult
            };
            return ResponseJson(execResult);

        }
    }
}
