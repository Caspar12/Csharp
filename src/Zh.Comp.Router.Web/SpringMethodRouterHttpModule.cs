using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;
using Zh.Framework.Tools;
using Zh.Web.Base.Helpers;
namespace Zh.Comp.Router.Web
{
    public class SpringMethodRouterHttpModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(context_BeginRequest);
        }
        static MethodRouter _Router;
        MethodRouter Router
        {
            get
            {
                if (_Router == null)
                {
                    _Router = ToolFactory.BLLIoc.Get<MethodRouter>("Zh.Comp.Router.Web.SpringMethodRouterHttpModule");
                }
                return _Router;
            }
        }
        void context_BeginRequest(object sender, EventArgs e)
        {
            var methodFormRouteData = new MethodFormRouteData()
            {
                Form = HttpContext.Current.Request.Path
            };
            if (Router.IsProcess(methodFormRouteData))
            {
                methodFormRouteData.Params = HttpContext.Current.Request.Params;
                var result = Router.Execute(methodFormRouteData);
                WebHelper.ResponseWriteJson(result);
                WebHelper.Response.End();
            }
        }
    }
}
