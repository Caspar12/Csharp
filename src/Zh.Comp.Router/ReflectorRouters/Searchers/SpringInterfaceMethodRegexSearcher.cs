using System;
using System.Collections.Generic;
using System.Text;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;

namespace Zh.Comp.Router.ReflectorRouters.Searchers
{
    /// <summary>
    /// 接口方法正式表达式搜索器
    /// </summary>
    public class SpringInterfaceMethodRegexSearcher : AbstractMethodRegexSearcher
    {
        protected override bool IsNotValidType(Type assemblyType)
        {
            if (base.IsNotValidType(assemblyType))
            {
                return true;
            }
            return assemblyType.IsInterface == false;
        }

        protected override MethodRouters.AbstractMethodRouteData CreateRouteData()
        {
            return new SpringMethodRouteData();
        }
    }
}
