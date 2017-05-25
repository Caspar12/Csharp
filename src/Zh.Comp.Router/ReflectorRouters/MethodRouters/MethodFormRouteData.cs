using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    public class MethodFormRouteData : AbstractFormRouteData
    { 
        public NameValueCollection Params { get; set; }
    }
}
