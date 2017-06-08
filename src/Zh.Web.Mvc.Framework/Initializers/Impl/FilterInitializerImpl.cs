using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zh.Framework.Tools;
using Zh.Framework.Tools.AppContextTool;
using Zh.Web.Mvc.Framework.Filters;

namespace Zh.Web.Mvc.Framework.Initializers.Impl
{
    /// <summary>
    /// 全局Filter 初始化程序
    /// </summary>
    public class FilterInitializerImpl : Initializer
    {
        public int Sort
        {
            get; set;
        } = 1;

        public void Init(HttpApplication application)
        {
            GlobalFilters.Filters.Add(new LogExceptionAttribute()
            {
                Order = 10000
            });

            GlobalFilters.Filters.Add(new ValidationAttribute()
            {
                Order = 10001
            });

            GlobalFilters.Filters.Add(new WebApiReturnJsonExceptionAttribute()
            {
                Order = 10002,
                IsNotOnlyFilterAjaxInvokeException = true
            });

        }

    }
}