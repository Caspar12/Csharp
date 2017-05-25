using System;
using System.Collections.Generic;
using System.Text;
using Zh.Comp.Router.Helpers;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Tools.ProgramTool;
using Zh.Framework.Tools;

namespace Zh.Comp.Router
{
    /// <summary>
    /// 抽象目标路由数据
    /// </summary>
    public abstract class AbstractRouteData
    {
        public AbstractRouteData()
        {
            this.RouteFilters = new List<AbstractRouteFilter>();
            this.RouteMappers = new List<AbstractRouteMapper>();
            this.IsOverrideTableRouteMappers = false;
        }
        protected IProgramTool ProgramTool
        {
            get
            {
                return ToolFactory.CreateIProgramTool();
            }
        }
        protected IValidatorTool IValidatorTool
        {
            get
            {
                return ToolFactory.CreateIValidatorTool();
            }
        }
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
        public virtual string To { get; set; }
        /// <summary>
        /// 是否覆盖路由表的映射方法
        /// </summary>
        public bool IsOverrideTableRouteMappers { get; set; }
        /// <summary>
        /// 是否匹配源路由数据
        /// </summary>
        /// <param name="formRouteData">目标路由数据</param>
        /// <param name="tableRouteMappers">路由表映射器</param>
        /// <returns></returns>
        public bool IsMatch(AbstractFormRouteData formRouteData, IList<AbstractRouteMapper> tableRouteMappers)
        {
            if (RouteFilterHelper.IsNotPassAllFilters(formRouteData, this.RouteFilters))
            {
                return false;
            }
            var routeMappers = new List<AbstractRouteMapper>(tableRouteMappers.Count + this.RouteMappers.Count);
            routeMappers.AddRange(this.RouteMappers);
            if (this.IsOverrideTableRouteMappers == false) routeMappers.AddRange(tableRouteMappers);
            foreach (var routeMapper in routeMappers)
            {
                if (routeMapper.IsMapping(formRouteData, this))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
