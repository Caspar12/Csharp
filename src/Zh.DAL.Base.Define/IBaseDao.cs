using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Entities;
using System.Collections;
using Zh.DAL.Base.Define.Query;
using Zh.DAL.Base.Define.Transactions;

namespace Zh.DAL.Base.Define
{
    public interface IBaseDao<T>
    {
        T Insert(T entity);
        T InsertOrUpdate(T entity);
        T Update(T entity);
        T Delete(object id);
        T Delete(T entity);
        IList<T> FindAll(IOrderByGetter orderBys = null);
        T FindById(object id);
        T FirstOrDefault(string propertyName, object value, IOrderByGetter orderBys = null);
        T FirstOrDefault(IWhereGetter where, IOrderByGetter orderBys = null);
        IList<T> FindByProperty(string propertyName, object value, IOrderByGetter orderBys = null);
        IList<T> FindByProperties(IWhereGetter where, IOrderByGetter orderBys = null);
        GenericPageResult<T> Page(IOrderByGetter orderBys, IWhereGetter where, int pageIndex = 1, int pageSize = 10);
        IList<T> Top(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null);
        TResult Max<TResult>(string propertyName, IWhereGetter where = null);
        TResult Min<TResult>(string propertyName, IWhereGetter where = null);
        TResult Avg<TResult>(string propertyName, IWhereGetter where = null);
        TResult Sum<TResult>(string propertyName, IWhereGetter where = null);
        TResult Count<TResult>(string propertyName, IWhereGetter where = null);
        IList<T> FindBySql(string sql);
        int Execute(string sql);
        void SaveChange();
        ITransaction GetCurrentTransaction();
    }
}
