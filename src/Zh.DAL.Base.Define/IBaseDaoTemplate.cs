using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define.Query;
using Zh.DAL.Base.Define.Entities;
using Zh.DAL.Base.Define.Transactions;
using Zh.Framework.Entities;

namespace Zh.DAL.Base.Define
{
    public interface IBaseDaoTemplate
    {
        T Insert<T>(T entity) where T : class;
        T InsertOrUpdate<T>(T entity) where T : class;
        T Update<T>(T entity) where T : class;
        T Delete<T>(object id) where T : class;
        T Delete<T>(T entity) where T : class;
        IList<T> FindAll<T>(IOrderByGetter orderBys = null) where T : class;
        T FindById<T>(object id) where T : class;
        IList<T> FindByProperty<T>(string propertyName, object value, IOrderByGetter orderBys = null) where T : class;
        IList<T> FindByProperties<T>(IWhereGetter where, IOrderByGetter orderByGetter = null) where T : class;
        T FirstOrDefault<T>(string propertyName, object value, IOrderByGetter orderByGetter = null) where T : class;
        T FirstOrDefault<T>(IWhereGetter where, IOrderByGetter orderByGetter = null) where T : class;
        GenericPageResult<T> Page<T>(IOrderByGetter orderByGetter, IWhereGetter where, int pageIndex = 1, int pageSize = 10) where T : class;
        IList<TEntity> Top<TEntity>(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null) where TEntity : class;
        TResult Max<TEntity, TResult>(string propertyName, IWhereGetter where) where TEntity : class;
        TResult Min<TEntity, TResult>(string propertyName, IWhereGetter where) where TEntity : class;
        TResult Avg<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class;
        TResult Sum<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class;
        TResult Count<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class;
        IList<T> FindBySql<T>(string sql);
        int Execute(string sql);
        void SaveChange();
        ITransaction GetCurrentTransaction();
    }
}
