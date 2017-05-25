using System;
using System.Collections.Generic;
using System.Text;
using Zh.Comp.Router.ReflectorRouters.MethodRouters;
using System.Text.RegularExpressions;

namespace Zh.Comp.Router.ReflectorRouters.Mappers
{
    /// <summary>
    /// 从Url到类方法映射类
    /// </summary>
    public class UrlToClassMethodMapper : AbstractRouteMapper
    {
        /// <summary>
        /// 获取类型名称正则表达式
        /// </summary>
        public string Type { get; set; }
        Regex RegexType
        {
            get
            {
                return new Regex(this.Type);
            }
        }
        /// <summary>
        /// 获取方法名称正则表达式
        /// </summary>
        public string Method { get; set; }
        Regex RegexMethod
        {
            get
            {
                return new Regex(this.Method);
            }
        }
        /// <summary>
        /// 类型名称模板
        /// </summary>
        public string TypeTemplate { get; set; }
        /// <summary>
        /// 方法名称模板
        /// </summary>
        public string MethodTemplate { get; set; }
        public override bool IsMapping(AbstractFormRouteData formRouteData, AbstractRouteData routeData)
        {
            var methodFormRouteData = (MethodFormRouteData)formRouteData;
            var methodRouteData = (AbstractMethodRouteData)routeData;
            var typeName = GetTypeName(methodFormRouteData);
            var methodName = GetMethodName(methodFormRouteData);
            if (!methodRouteData.MethodInfo.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase) ||
                !methodRouteData.ServiceType.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return true;
        }

        private string GetMethodName(MethodFormRouteData methodFormRouteData)
        {
            var match = RegexMethod.Match(methodFormRouteData.Form);
            if (match.Success == false)
            {
                return string.Empty;
            }
            var value = match.Groups["Method"].Value;
            if (string.IsNullOrEmpty(this.MethodTemplate))
            {
                return value;
            }
            return string.Format(this.MethodTemplate, value);
        }

        string GetTypeName(MethodFormRouteData methodFormRouteData)
        {
            var match = RegexType.Match(methodFormRouteData.Form);
            if (match.Success == false)
            {
                return string.Empty;
            }
            var value = match.Groups["Type"].Value;
            if (string.IsNullOrEmpty(this.TypeTemplate))
            {
                return value;
            }
            return string.Format(this.TypeTemplate, value);
        }
    }
}
