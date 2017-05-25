using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools;
using System.Reflection;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    public class SpringMethodRouteData : AbstractMethodRouteData
    {
        public override object Execute(MethodFormRouteData formRouteData)
        {
            var service = ToolFactory.BLLIoc.Get(this.ServiceType);
            var objParams = GetParamsFormFormRouteData(formRouteData);
            var realMethodInfo = this.GetRealServiceMethodInfo(service);
            return realMethodInfo.Invoke(service, objParams);
        }
        MethodInfo _RealServiceMethodInfo;
        public MethodInfo GetRealServiceMethodInfo(object service)
        {
            if (_RealServiceMethodInfo == null)
            {
                foreach (var realMethodInfo in service.GetType().GetMethods())
                {
                    if (IsRealMethodInfo(realMethodInfo))
                    {
                        _RealServiceMethodInfo = realMethodInfo;
                        break;
                    }
                }
            }
            return _RealServiceMethodInfo;
        }

        protected bool IsRealMethodInfo(MethodInfo realMethodInfo)
        {
            if (realMethodInfo.Name != this.MethodInfo.Name) return false;

            if (realMethodInfo.GetParameters().Length != this.MethodInfo.GetParameters().Length) return false;

            var isAllPropInfoOk = IsMatchAllRealMethodParameters(realMethodInfo.GetParameters());

            return isAllPropInfoOk;
        }

        private bool IsMatchAllRealMethodParameters(ParameterInfo[] realMethodParameterInfos)
        {
            for (var i = 0; i < realMethodParameterInfos.Length; i++)
            {
                var realMethodParameterInfo = realMethodParameterInfos[i];
                var methodParameterInfo = this.ParameterInfos[i];
                if (methodParameterInfo.Name != realMethodParameterInfo.Name &&
                         methodParameterInfo.ParameterType != realMethodParameterInfo.ParameterType)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
