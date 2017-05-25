using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Helpers;

namespace Zh.Framework.Tools.EntityTool
{
    public class EntityMapper
    {
        public static TDest Map<TSrc, TDest>(TSrc src)
            where TSrc : class
            where TDest : class
        {
            EntityToolImp tool = new EntityToolImp();
            return tool.Map<TSrc, TDest>(src);
        }

        public static IList<TDest> Map<TSrc, TDest>(IEnumerable<TSrc> src)
            where TSrc : class
            where TDest : class
        {
            if (src == null) return new List<TDest>(0);
            IList<TDest> result = new List<TDest>();
            foreach (var item in src)
            {
                var dest = Map<TSrc, TDest>(item);
                result.Add(dest);
            }
            return result;
        }


    }
}
