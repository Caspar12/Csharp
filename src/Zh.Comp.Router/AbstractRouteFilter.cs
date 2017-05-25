using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router
{
    public abstract class AbstractRouteFilter
    {
        public string Id { get; set; }
        public abstract bool IsPass(AbstractFormRouteData formRouteData);
        public bool IsNotPass(AbstractFormRouteData formRouteData)
        {
            return !IsPass(formRouteData);
        }
    }
}
