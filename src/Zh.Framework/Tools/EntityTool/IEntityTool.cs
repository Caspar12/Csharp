using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.EntityTool.BindingTool.NVCollectionBinder;
using System.Collections.Specialized;

namespace Zh.Framework.Tools.EntityTool
{
    public interface IEntityTool
    {
        INVCollectionBinder CreateINVCollectionBinder(NameValueCollection pNameValueCollection);

        /// <summary>
        /// 映射基本类型数据
        /// </summary>
        /// <typeparam name="TSrc">源对象类型</typeparam>
        /// <typeparam name="TDest">生成目标对象类型</typeparam>
        /// <param name="src">源对象</param>
        /// <returns></returns>
        TDest Map<TSrc, TDest>(TSrc src)
            where TSrc : class
            where TDest : class;
        /// <summary>
        /// 映射基本类型数据
        /// </summary>
        /// <typeparam name="TSrc">源对象类型</typeparam>
        /// <typeparam name="TDest">生成目标对象类型</typeparam>
        /// <param name="src">源对象</param>
        /// <returns></returns>
        IList<TDest> Map<TSrc, TDest>(IEnumerable<TSrc> src)
            where TSrc : class
            where TDest : class;



    }
}
