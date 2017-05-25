using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router.ReflectorRouters.Searchers
{
    /// <summary>
    /// 抽象搜索器
    /// </summary>
    public abstract class AbstractSearcher : IRouteTableConfigSearcher
    {
        public AbstractSearcher()
        {
            this.RouteFilters = new List<AbstractRouteFilter>();
            this.RouteMappers = new List<AbstractRouteMapper>();
            this.IsOverrideTableRouteMappers = false;
        }
        /// <summary>
        /// 路由表名称 
        /// </summary>
        public string RouteTableName { get; set; }
        /// <summary>
        /// 程序集名称
        /// </summary>
        public string AssemblyName { get; set; }
        /// <summary>
        /// 搜索到的RouteData数据关联的RouteFilters
        /// </summary>
        public List<AbstractRouteFilter> RouteFilters { get; set; }
        /// <summary>
        /// 搜索到的RouteData数据关联的RouteMappers
        /// </summary>
        public List<AbstractRouteMapper> RouteMappers { get; set; }
        /// <summary>
        /// 是否覆盖路由表映射器
        /// </summary>
        public bool IsOverrideTableRouteMappers { get; set; }
        /// <summary>
        /// 搜索RouteData数据
        /// IRouteTableConfigSearcher接口Search方法
        /// </summary>
        /// <returns>RouteData数据集合</returns>
        public abstract IList<AbstractRouteData> Search();
    }
}
