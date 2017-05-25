using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Comp.Router.ReflectorRouters.MethodRouters
{
    public class MethodRouteTable : AbstractRouteTable
    {
        /// <summary>
        /// RouteData数据查询类
        /// </summary>
        public IList<IRouteTableConfigSearcher> Searchers { get; set; }
        /// <summary>
        /// 从Searchers初始化数据
        /// </summary>
        public void InitFromSearchers()
        {
            if (this.IValidatorTool.IsEmpty(this.Searchers)) return;

            foreach (var searcher in Searchers)
            {
                var routeDatas = searcher.Search();
                this.RouteDatas.AddRange(routeDatas);
            }
        }
    }
}
