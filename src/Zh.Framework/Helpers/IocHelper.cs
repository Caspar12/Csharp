using Spring.Objects.Factory.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Helpers
{
    public static class IocHelper
    {
        public static void RegisterSingleton<T>(IConfigurableListableObjectFactory objectFactory) where T : class, new()
        {
            Type type = typeof(T);
            var instance = new T();
            objectFactory.RegisterSingleton(type.FullName, instance);
        }
    }
}
