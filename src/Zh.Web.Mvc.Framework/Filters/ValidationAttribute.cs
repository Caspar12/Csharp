using log4net;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Entities;
using Zh.Framework.Exceptions;

namespace Zh.Web.Mvc.Framework.Filters
{
    /// <summary>
    /// Model验证拦截器
    /// </summary>
    public class ValidationAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!(filterContext.Controller.ControllerContext.Controller is Controller)) return;

            var controller = (Controller)filterContext.Controller.ControllerContext.Controller;
            if (controller.ModelState.IsValid) return;
            var keyList = controller.ModelState.Keys.ToList();
            var valueList = controller.ModelState.Values.ToList();


            Dictionary<string, List<string>> allErrors = new Dictionary<string, List<string>>();
            for (var i = 0; i < keyList.Count; i++)
            {
                var key = keyList[i];
                var modelState = valueList[i];
                if (modelState.Errors.Count <= 0) continue;
                List<string> errors = new List<string>(modelState.Errors.Count);

                var modelStateErrorList = modelState.Errors.ToList();
                foreach (var error in modelStateErrorList)
                {
                    errors.Add(error.ErrorMessage);
                }
                allErrors.Add(key, errors);

            }
            var firstErrorItem = allErrors.Where(p => p.Value.Count > 0).FirstOrDefault();
            var firstField = firstErrorItem.Key;
            var firstMessage = firstErrorItem.Value[0];

            Zh.Framework.Exceptions.ConstraintsValidationException ex = new ConstraintsValidationException(firstField, firstMessage);
            ex.Errors = allErrors;

            throw ex;
        }


    }
}