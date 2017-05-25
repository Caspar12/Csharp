using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class IQueryableExtend
    {
        public static IQueryable<TEntity> Page<TEntity>(this IQueryable<TEntity> q, int pageIndex = 1, int pageSize = 10)
        {
            if (pageIndex <= 0) { pageIndex = 1; }
            if (pageSize <= 0) { pageSize = 10; }

           return q.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

       
    }
}
