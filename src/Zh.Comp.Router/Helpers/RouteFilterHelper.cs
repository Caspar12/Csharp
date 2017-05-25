using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router.Helpers
{
    public class RouteFilterHelper
    {
        public static bool IsNotPassAllFilters(AbstractFormRouteData formRouteData, IEnumerable<AbstractRouteFilter> routeFilters)
        {
            return IsPassAllFilters(formRouteData, routeFilters) == false;
        }
        public static bool IsPassAllFilters(AbstractFormRouteData formRouteData, IEnumerable<AbstractRouteFilter> routeFilters)
        {          
            foreach (var routeFilter in routeFilters)
            {
                if (routeFilter.IsNotPass(formRouteData))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
