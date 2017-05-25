using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;
using System.IO;

namespace Zh.Comp.Router.Test
{
    class Program
    {
        static void Main(string[] args)
        {             
            MethodRouter router = ToolFactory.BLLIoc.Get<MethodRouter>("ClassMethodRouterExample");
            var tParams = new System.Collections.Specialized.NameValueCollection();
            tParams.Add("paramA", "paramAc");
            var r = router.Execute(new MethodFormRouteData()
            {
                Form = "/app/comcount/Test",
                Params = tParams
            });
        }
    }
}
