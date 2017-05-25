using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Tools;
using Zh.Comp.Router.Helpers;

namespace Zh.Comp.Router
{
    public abstract class AbstractRouter
    {
        protected IValidatorTool IValidatorTool
        {
            get
            {
                return ToolFactory.CreateIValidatorTool();
            }
        }
        /// <summary>
        /// 是否进入路由器处理
        /// </summary>
        /// <param name="formRouteData"></param>
        /// <returns></returns>
        public bool IsProcess(AbstractFormRouteData formRouteData)
        {
            foreach (var routeTable in this.RouteTables)
            {
                if (RouteFilterHelper.IsPassAllFilters(formRouteData, routeTable.RouteFilters))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 路由数据表
        /// </summary>
        public IList<AbstractRouteTable> RouteTables { get; set; }
        /// <summary>
        /// 查找路由数据
        /// </summary>
        /// <param name="formRouteData">源路由数据</param>
        /// <returns>目标路由数据集合</returns>
        public virtual IList<AbstractRouteData> FindRouteData(AbstractFormRouteData formRouteData)
        {
            var result = new List<AbstractRouteData>();
            foreach (var routeTable in RouteTables)
            {
                var fRouteDatas = routeTable.FindRouteData(formRouteData);
                result.AddRange(fRouteDatas);
            }
            return result;
        }
    }
}
