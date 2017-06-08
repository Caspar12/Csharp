using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zh.Web.Mvc.Framework.Initializers;

namespace Zh.Web.Mvc.Framework
{
    /// <summary>
    /// 获取 HttpMvcApplication 需要加载的初始化程序,默认实现Zh.Web.Mvc.Framework.Impl.GetInitializersImpl
    /// </summary>
    public interface GetInitializers
    {
        /// <summary>
        /// 获取 HttpMvcApplication 需要加载的初始化程序
        /// </summary>
        /// <returns>初始化程序</returns>
        List<Initializer> Get();
    }
}