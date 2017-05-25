using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zh.Comp.Router.Filters
{
    /// <summary>
    /// 过滤路由数据过滤器
    /// </summary>
    public class RegexFilter : AbstractRouteFilter
    {
        /// <summary>
        /// 来源路由数据准备匹配正则表达式
        /// </summary>
        public string Form { get; set; }
        public Regex RegexForm
        {
            get
            {
                return new Regex(Form);
            }
        }
        public override bool IsPass(AbstractFormRouteData formRouteData)
        {
            return this.RegexForm.IsMatch(formRouteData.Form);
        }
    }
}
