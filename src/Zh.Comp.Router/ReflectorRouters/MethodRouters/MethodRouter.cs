using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    /// <summary>
    /// 反射方法路由器
    /// </summary>
    public class MethodRouter : AbstractRouter
    {
        #region 方法
        /// <summary>
        /// 查找最高匹配目标路由
        /// </summary>
        /// <param name="formRouteData">源路由</param>
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns></returns>
        IList<AbstractMethodRouteData> FindMaxMatchRouteDatas(MethodFormRouteData formRouteData, IList<AbstractMethodRouteData> baseRouteDatas)
        {
            var result = new List<AbstractMethodRouteData>();
            int maxMatchParamCount = GetRouteDatasMaxMatchParamCount(formRouteData, baseRouteDatas);
            if (maxMatchParamCount == 0)
            {
                return FindMinParamCountRouteDatas(baseRouteDatas);
            }
            return FindMaxMatchParamCountRouteDatas(formRouteData, baseRouteDatas);
        }
        /// <summary>
        /// 查找最匹配目标路由
        /// </summary>
        /// <param name="formRouteData">源路由</param>
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns></returns>
        IList<AbstractMethodRouteData> FindMaxMatchParamCountRouteDatas(MethodFormRouteData formRouteData, IList<AbstractMethodRouteData> baseRouteDatas)
        {
            int mostMatchParamCount = GetRouteDatasMaxMatchParamCount(formRouteData, baseRouteDatas);
            var result = this.FindMatchParamCountRouteDatas(formRouteData, baseRouteDatas, mostMatchParamCount);
            return result;
        }
        /// <summary>
        /// 查找匹配参数名称数量路由
        /// </summary>
        /// <param name="formRouteData">源路由</param>
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns></returns>
        IList<AbstractMethodRouteData> FindMatchParamCountRouteDatas(MethodFormRouteData formRouteData, IList<AbstractMethodRouteData> baseRouteDatas, int findMatchParamCount)
        {
            var result = new List<AbstractMethodRouteData>();
            foreach (var routeData in baseRouteDatas)
            {
                var methodRouteData = routeData;
                var matchParamCount = GetMatchParamCount(formRouteData, methodRouteData);
                if (matchParamCount == findMatchParamCount)
                {
                    result.Add(routeData);
                }
            }
            return result;
        }
        /// <summary>
        /// 获取源路由参数与目标路由参数名称最多匹配数量
        /// </summary>
        /// <param name="formRouteData">源路由</param>
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns>最多匹配参数数量</returns>
        int GetRouteDatasMaxMatchParamCount(MethodFormRouteData formRouteData, IList<AbstractMethodRouteData> baseRouteDatas)
        {
            var maxMatchParamCount = 0;
            foreach (var routeData in baseRouteDatas)
            {
                var fMaxMatchParamCount = GetMatchParamCount(formRouteData, routeData);
                if (maxMatchParamCount < fMaxMatchParamCount)
                {
                    maxMatchParamCount = fMaxMatchParamCount;
                }
            }
            return maxMatchParamCount;
        }
        /// <summary>
        /// 获取最少参数数量目标路由
        /// </summary>
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns>最少参数数量目标路由</returns>
        IList<AbstractMethodRouteData> FindMinParamCountRouteDatas(IList<AbstractMethodRouteData> baseRouteDatas)
        {
            var minParamCount = GetRouteDatasMinParamCount(baseRouteDatas);
            var result = new List<AbstractMethodRouteData>();
            foreach (var routeData in baseRouteDatas)
            {
                var paramCount = routeData.ParameterInfos.Count;
                if (minParamCount == paramCount)
                {
                    result.Add(routeData);
                }
            }
            return result;
        }
        /// <summary>
        /// 获取目标路由最少参数数量
        /// </summary> 
        /// <param name="baseRouteDatas">目标路由</param>
        /// <returns>最少参数数量</returns>
        int GetRouteDatasMinParamCount(IList<AbstractMethodRouteData> baseRouteDatas)
        {
            var minParamCount = int.MaxValue;
            foreach (var routeData in baseRouteDatas)
            {
                var paramCount = routeData.ParameterInfos.Count;
                if (minParamCount > paramCount)
                {
                    minParamCount = paramCount;
                }
            }
            return minParamCount;
        }
        /// <summary>
        /// 获取源路由参数与目标路由参数名称匹配数量,类变量参数以字符"."分割
        /// </summary>
        /// <param name="formRouteData">源路由</param>
        /// <param name="methodRouteData">目标路由</param>
        /// <returns>匹配参数数量</returns>
        int GetMatchParamCount(MethodFormRouteData formRouteData, AbstractMethodRouteData methodRouteData)
        {
            var matchCount = 0;

            foreach (var parameterInfo in methodRouteData.ParameterInfos)
            {
                foreach (var formRouteDataParamName in formRouteData.Params.AllKeys)
                {
                    var paramName = string.Empty;
                    if (parameterInfo.ParameterType.IsClass &&
                        parameterInfo.ParameterType != typeof(string) &&
                       typeof(IEnumerable).IsAssignableFrom(parameterInfo.ParameterType) == false)
                    {
                        var paramNames = formRouteDataParamName.Split('.');
                        if (paramNames.Length > 1)
                        {
                            paramName = paramNames[0];
                        }
                    }
                    else
                    {
                        paramName = formRouteDataParamName;
                    }
                    if (parameterInfo.Name.Equals(paramName, StringComparison.OrdinalIgnoreCase))
                    {
                        matchCount++;
                    }
                }
            }
            return matchCount;
        }
        /// <summary>
        /// 从匹配的目标路由集合中查找匹配的目标路由
        /// </summary>
        /// <param name="formRouteData">源路由数据</param>
        /// <returns>配置的目标路由数据</returns>
        public AbstractMethodRouteData FindRouteData(MethodFormRouteData formRouteData)
        {
            var baseRouteData = base.FindRouteData(formRouteData);
            if (IValidatorTool.IsEmpty(baseRouteData))
            {
                throw new Exception(string.Format("没有查找到{0},相关的映射方法", formRouteData.Form));
            }
            if (baseRouteData.Count == 1)
            {
                return (AbstractMethodRouteData)baseRouteData[0];
            }

            var methodFormRouteData = (MethodFormRouteData)formRouteData;
            List<AbstractMethodRouteData> methodRouteDatas = new List<AbstractMethodRouteData>(baseRouteData.Count);
            foreach (var item in baseRouteData)
            {
                methodRouteDatas.Add((AbstractMethodRouteData)item);
            }
            IList<AbstractMethodRouteData> routeDatas = this.FindMaxMatchRouteDatas(methodFormRouteData, methodRouteDatas);
            if (IValidatorTool.IsEmpty(routeDatas))
            {
                throw new Exception(string.Format("没有查找到{0},相关的映射方法", methodFormRouteData.Form));
            }

            if (routeDatas.Count > 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},查找到多个映射方法", methodFormRouteData.Form);
                foreach (var item in routeDatas)
                {
                    var reflectorRouteData = (AbstractMethodRouteData)item;
                    sb.AppendLine(reflectorRouteData.ServiceType.FullName + "." + reflectorRouteData.MethodInfo.Name);
                }
                throw new Exception(sb.ToString());
            }
            return routeDatas[0];
        }
        /// <summary>
        /// 执行映射方法
        /// </summary>
        /// <param name="formRouteData">源路由数据</param>
        /// <returns>执行结果</returns>
        public object Execute(MethodFormRouteData formRouteData)
        {
            var routeData = this.FindRouteData(formRouteData);
            return routeData.Execute(formRouteData);
        }

        #endregion
    }
}
