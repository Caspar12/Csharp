using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router
{
    public interface IRouteTableConfigSearcher
    {
        /// <summary>
        /// 搜索RouteData数据
        /// </summary>
        /// <returns>RouteData数据集合</returns>
        IList<AbstractRouteData> Search();
    }
}
