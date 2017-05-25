using System;
using System.Collections.Generic;
using System.Text;
using Zh.Comp.Router.Helpers;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Tools;
namespace Zh.Comp.Router
{
    /// <summary>
    /// 抽象路由表
    /// </summary>
    public abstract class AbstractRouteTable
    {
        public AbstractRouteTable()
        {
            this.RouteFilters = new List<AbstractRouteFilter>();
            this.RouteMappers = new List<AbstractRouteMapper>();
            this.RouteDatas = new List<AbstractRouteData>();
        }
        protected IValidatorTool IValidatorTool
        {
            get
            {
                return ToolFactory.CreateIValidatorTool();
            }
        }
        /// <summary>
        /// 路由表Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 路由数据过滤器
        /// </summary>
        public List<AbstractRouteFilter> RouteFilters { get; set; }
        /// <summary>
        /// 路由数据映射转换器
        /// </summary>
        public List<AbstractRouteMapper> RouteMappers { get; set; }
        /// <summary>
        /// 目标路由数据
        /// </summary>
        public List<AbstractRouteData> RouteDatas { get; set; } 
        /// <summary>
        /// 查找目标路由数据
        /// </summary>
        /// <param name="formRouteData">目标路由数据</param>
        /// <returns>目标路由数据集合</returns>
        internal IList<AbstractRouteData> FindRouteData(AbstractFormRouteData formRouteData)
        {
            List<AbstractRouteData> routeDatas = new List<AbstractRouteData>();
            if (RouteFilterHelper.IsNotPassAllFilters(formRouteData, this.RouteFilters))
            {
                return routeDatas;
            }
            foreach (var routeData in this.RouteDatas)
            {
                if (routeData.IsMatch(formRouteData, this.RouteMappers))
                {
                    routeDatas.Add(routeData);
                }
            }
            return routeDatas;
        }

    }
}
