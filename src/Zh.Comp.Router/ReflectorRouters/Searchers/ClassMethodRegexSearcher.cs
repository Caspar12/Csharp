using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;

namespace Zh.Comp.Router.ReflectorRouters.Searchers
{
    /// <summary>
    /// 类方法正式表达式搜索器
    /// </summary>
    public class ClassMethodRegexSearcher : AbstractMethodRegexSearcher
    {
        protected override bool IsNotValidType(Type assemblyType)
        {
            if (base.IsNotValidType(assemblyType))
            {
                return true;
            }
            return assemblyType.IsClass == false;
        }

        protected override AbstractMethodRouteData CreateRouteData()
        {
            return new ClassMethodRouteData();
        }
    }
}
