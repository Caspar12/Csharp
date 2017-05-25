using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router
{
    /// <summary>
    /// 源路由映射到目标路由类
    /// </summary>
    public abstract class AbstractRouteMapper
    {
        /// <summary>
        /// 是否可以从源路由映射到目标路由
        /// </summary>
        public abstract bool IsMapping(AbstractFormRouteData formRouteData, AbstractRouteData routeData);
    }
}
