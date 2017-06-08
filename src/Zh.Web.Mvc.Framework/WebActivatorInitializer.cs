using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zh.Framework.Tools;
using Zh.Web.Mvc.Framework;
using Zh.Web.Mvc.Framework.Impl;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(WebActivatorInitializer), "Init")]
namespace Zh.Web.Mvc.Framework
{
    //提供一個静态方法供Application_Start()之后触发
    public class WebActivatorInitializer
    {


        public static GetInitializers GetInitializers { get; set; }
        public static void Init()
        {
            GetInitializers = ToolFactory.Ioc.Get<GetInitializers>();
            if (GetInitializers == null)
            {
                GetInitializers = new GetInitializersImpl();
            }

            GetInitializers.Get().OrderBy(p => p.Sort).ToList().ForEach(p => p.Init(HttpContext.Current.ApplicationInstance));
        }

    }
}