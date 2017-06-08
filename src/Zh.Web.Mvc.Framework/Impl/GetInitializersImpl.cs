using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zh.Web.Mvc.Framework.Initializers;
using Zh.Web.Mvc.Framework.Initializers.Impl;

namespace Zh.Web.Mvc.Framework.Impl
{
    /// <summary>
    /// GetInitializers的默认实现,返回日志拦截器,异常验证拦截器,webapi json异常拦截器
    /// </summary>
    public class GetInitializersImpl : GetInitializers
    {
        private static List<Initializer> initializers = new List<Initializer>()
            {
                new Log4netInitializerImpl(),
                new FilterInitializerImpl()
            };

        public List<Initializer> Get()
        {
            return initializers;
        }
    }
}