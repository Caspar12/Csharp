using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Zh.Framework.Tools.EntityTool;
using Zh.Framework.Tools;
using System.Collections.Specialized;
using System.Collections;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    /// <summary>
    /// 抽象反射方法目标路由数据
    /// </summary>
    public abstract class AbstractMethodRouteData : AbstractRouteData
    {
        #region 工具接口
        IEntityTool IEntityTool
        {
            get
            {
                return ToolFactory.CreateIEntityTool();
            }
        }
        #endregion
        /// <summary>
        /// 方法参数
        /// </summary>
        internal IList<ParameterInfo> ParameterInfos { get; set; }
        /// <summary>
        /// 目标路由关联的方法
        /// </summary>
        internal MethodInfo MethodInfo { get; set; }
        /// <summary>
        /// 目标路由关联的类型
        /// </summary>
        internal Type ServiceType { get; set; }
        /// <summary>
        /// 运行目标路由关联方法
        /// </summary>
        /// <param name="formRouteData">源路由数据</param>
        /// <returns>运行结果</returns>
        public abstract object Execute(MethodFormRouteData formRouteData);
        /// <summary>
        /// 源路由数据转换运行方法参数
        /// </summary>
        /// <param name="formRouteData">源路由数据</param>
        /// <returns>运行方法参数</returns>
        protected virtual object[] GetParamsFormFormRouteData(MethodFormRouteData formRouteData)
        {
            if (this.ParameterInfos.Count == 0)
            {
                return null;
            }
            var result = new List<object>(ParameterInfos.Count);
            foreach (var parameterInfo in this.ParameterInfos)
            {
                if (IsHasParamterInFormRouteData(formRouteData, parameterInfo))
                {
                    if (parameterInfo.ParameterType.IsClass &&
                        typeof(IEnumerable).IsAssignableFrom(parameterInfo.ParameterType) == false)
                    {
                        var startWidthPath = parameterInfo.Name + ".";
                        NameValueCollection nvc = new NameValueCollection();
                        foreach (var key in formRouteData.Params.AllKeys)
                        {
                            if (key.StartsWith(startWidthPath, StringComparison.OrdinalIgnoreCase))
                            {
                                var propertyPath = key.Substring(startWidthPath.Length);
                                foreach (var value in formRouteData.Params.GetValues(key))
                                {
                                    nvc.Add(propertyPath, value);
                                }
                            }
                        }
                        var binder = IEntityTool.CreateINVCollectionBinder(nvc);
                        var paramValue = binder.Bind(parameterInfo.ParameterType);
                        result.Add(paramValue);
                    }
                    else
                    {
                        var srcValue = formRouteData.Params.GetValues(parameterInfo.Name);
                        object paramValue = null;
                        try
                        {
                            paramValue = ProgramTool.ChanageType(srcValue, parameterInfo.ParameterType);
                        }
                        catch
                        {
                            if (parameterInfo.DefaultValue != System.DBNull.Value)
                            {
                                paramValue = parameterInfo.DefaultValue;
                            }
                        } 
                        result.Add(paramValue);
                    }
                }
                else
                {
                    if (parameterInfo.DefaultValue != System.DBNull.Value)
                    {
                        result.Add(parameterInfo.DefaultValue);
                    }
                    else
                    {
                        result.Add(null);
                    }

                }

            }
            return result.ToArray();
        }
        protected bool IsHasParamterInFormRouteData(MethodFormRouteData formRouteData, ParameterInfo parameterInfo)
        {
            foreach (var key in formRouteData.Params.AllKeys)
            {
                if (parameterInfo.Name.Equals(key, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
