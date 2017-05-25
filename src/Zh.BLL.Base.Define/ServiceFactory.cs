using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.IocTool;
using Zh.Framework.Tools;

namespace Zh.BLL.Base.Define
{
    public class ServiceFactory
    {
        static IIocTool Ioc;
        public static T Get<T>(string name = null) where T : class
        {
            if (Ioc == null)
            {
                Ioc = ToolFactory.BLLIoc;
            }

            return Ioc.Get<T>();
        }
    }
}
