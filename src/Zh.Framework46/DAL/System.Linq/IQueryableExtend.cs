using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zh.Framework.Entities;

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



        public static GenericPageResult<TEntity> Page2<TEntity>(this IQueryable<TEntity> q, int pageIndex = 1, int pageSize = 10)
        {
            var data = q.Page(pageIndex, pageSize).ToList();
            return new GenericPageResult<TEntity>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Total = q.Count(),
                Data = data
            };
        }

        public static GenericPageResult<TEntity> Page2<TEntity>(this IEnumerable<TEntity> q, int pageIndex = 1, int pageSize = 10)
        {
            return q.AsQueryable().Page2(pageIndex, pageSize);

        }
    }
}
