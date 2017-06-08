using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Entities;

namespace Zh.Web.Mvc.Framework.Helpers
{
    public class ControllerHelper
    {
        public static JsonResult ToJsonResult(object o)
        {
            return new JsonResult()
            {
                Data = o,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                ContentEncoding = Encoding.UTF8,
                ContentType = "application/json"
            };
        }
        /// <summary>
        /// 创建成功回应
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
       
        public static JsonResult ToSuccessJsonResult<T>(T o)
        {
            GenericApiResult<T> r = new GenericApiResult<T>()
            {
                success = true,
                data = o,
                message = "",
                code = 0
            };
          
            return ToJsonResult(r);
        }
        /// <summary>
        /// 创建成功回应
        /// </summary>      
        /// <returns></returns>
        public static JsonResult ToSuccessJsonResult()
        {
            GenericApiResult<string> r = new GenericApiResult<string>()
            {
                success = true,                
                message = "",
                code = 0
            };
            return ToJsonResult(r);
        }
        /// <summary>
        /// 创建调用失败的回应
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static JsonResult ToFailureJsonResult<T>(string message, int code = -1)
        {
            GenericApiResult<T> r = new GenericApiResult<T>()
            {
                success = false,
                message = message,
                code = code
            };
            return ToJsonResult(r);
        }
    }
}