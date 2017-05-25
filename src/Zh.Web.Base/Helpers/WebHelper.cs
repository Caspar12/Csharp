using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.SessionState;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Tools;
namespace Zh.Web.Base.Helpers
{
    public class WebHelper
    {
        public static HttpContext Context
        {
            get
            {
                return HttpContext.Current;
            }
        }
        public static HttpSessionState Session
        {
            get
            {
                return Context.Session;
            }
        }

        public static HttpServerUtility Server
        {
            get
            {
                return Context.Server;
            }
        }
        public static HttpRequest Request
        {
            get
            {
                return Context.Request;
            }
        }
        public static HttpResponse Response
        {
            get
            {
                return Context.Response;
            }
        }

        public static T RequestParam<T>(string parameterName, T defaultValue = default( T))
        {
            IValidatorTool validator = ToolFactory.CreateIValidatorTool();
            var srcRequestValue = Request[parameterName];
            if (validator.IsEmpty(srcRequestValue))
            {
                return default(T);
            }
            T value = ToolFactory.CreateIProgramTool().ChanageType<T>(srcRequestValue);
            if (value == null && defaultValue != null)
            {
                return defaultValue;
            }
            return value;
        }

        public static void ResponseWriteJson(object obj)
        {
            Response.ContentType = "application/json";
            Response.Write(ToolFactory.CreateIJsonSerializeTool().SerializeToString(obj));
        }

    }
}
