using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Zh.Web.Mvc.Framework.Initializers
{
    /// <summary>
    /// HttpMvcApplication 初始化程序
    /// </summary>
    public interface Initializer
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="application"></param>
        void Init(HttpApplication application);
        /// <summary>
        /// 初始化顺序
        /// </summary>
        int Sort { get; set; }
    }
}
