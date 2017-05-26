using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Zh.EntityFrameworkEx;
using Zh.EntityFrameworkEx.Impl;

namespace Zh.EntityFrameworkEx
{
    public static class DbContextExtension
    {
        /// <summary>
        /// 根据Id,更新部分字段
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dbContext"></param>
        /// <param name="func"></param>
        public static UpdateSetProperty<TEntity> Update<TEntity>(this DbContext dbContext, object id) where TEntity : class, new()
        {
            UpdateSetProperty<TEntity> updateSetProperty = new UpdateSetPropertyImpl<TEntity>(dbContext, id);
            return updateSetProperty;
        }
    }
}
