using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    public class ClassMethodRouteData : AbstractMethodRouteData
    {
        public override object Execute(MethodFormRouteData formRouteData)
        {
            var service = Activator.CreateInstance(ServiceType);
            var objParams = GetParamsFormFormRouteData(formRouteData);
            return this.MethodInfo.Invoke(service, objParams);
        }
    }
}
