using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Entities;
using Zh.Framework.Exceptions;
using Zh.Web.Mvc.Framework.Helpers;
using Zh.Web.Mvc.Framework.Test.Models;

namespace Zh.Web.Mvc.Framework.Test.Controllers
{
    public class WebApiController : Controller
    {
        [HttpPost]
        public ActionResult TestModelValid(ConstraintsValidationExceptionTest test)
        {
            return ControllerHelper.ToSuccessJsonResult();
        }

        // GET: WebApi
        public ActionResult Success()
        {
            return ControllerHelper.ToJsonResult(new GenericApiResult<string>()
            {
                success = false,
                message = "OK",
                code = 0
            });
        }

        public ActionResult ValidationException()
        {
            throw new ValidationException("ValidationException", -1);
        }
        public ActionResult Exception()
        {
            throw new Exception("Exception5");
        }
    }
}