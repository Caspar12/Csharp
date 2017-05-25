using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define.Query;
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework.Entities;

namespace Zh.DAL.Base.Define
{
    public class BaseDao<T> : IBaseDao<T> where T : class
    {
        /// <summary>
        /// 只用作注入验证接口,只在数据访问层中使用
        /// </summary>
        public IValidatorTool IValidatorTool { get; set; }
        /// <summary>
        /// 只用作注入基础Dao数据访问接口模板,只在数据访问层中使用
        /// </summary>
        public IBaseDaoTemplate DaoTemplate { protected get; set; }
        public T Insert(T entity)
        {
            var newEntity = this.DaoTemplate.Insert(entity);
            return newEntity;
        }

        public T InsertOrUpdate(T entity)
        {
            this.DaoTemplate.InsertOrUpdate(entity);
            return entity;
        }

        public T Update(T entity)
        {
            this.DaoTemplate.Update(entity);
            return entity;
        }

        public T Delete(object id)
        {
            var entity = this.FindById(id);
            if (entity == null)
            {
                return null;
            }

            this.DaoTemplate.Delete(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            this.DaoTemplate.Delete(entity);
            return entity;
        }

        public T FindById(object id)
        {
            return this.DaoTemplate.FindById<T>(id);
        }

        public IList<T> FindAll(IOrderByGetter orderBys = null)
        {
            return this.DaoTemplate.FindAll<T>(orderBys);
        }

        public IList<T> FindByProperties(IWhereGetter where, IOrderByGetter orderByGetter = null)
        {
            return this.DaoTemplate.FindByProperties<T>(where, orderByGetter);
        }

        public GenericPageResult<T> Page(IOrderByGetter orderBys, IWhereGetter where, int pageIndex = 1, int pageSize = 10)
        {
            return this.DaoTemplate.Page<T>(orderBys, where, pageIndex, pageSize);
        }

        public T FirstOrDefault(IWhereGetter where, IOrderByGetter iOrderByGetter = null)
        {
            return this.DaoTemplate.FirstOrDefault<T>(where, iOrderByGetter);
        }

        public T FirstOrDefault(string propertyName, object value, IOrderByGetter orderBys = null)
        {
            return this.DaoTemplate.FirstOrDefault<T>(propertyName, value, orderBys);
        }

        public IList<T> FindByProperty(string propertyName, object value, IOrderByGetter orderBys = null)
        {
            return this.DaoTemplate.FindByProperty<T>(propertyName, value, orderBys);
        }



        public Transactions.ITransaction GetCurrentTransaction()
        {
            return this.DaoTemplate.GetCurrentTransaction();
        }


        public TResult Max<TResult>(string propertyName, IWhereGetter where)
        {
            return this.DaoTemplate.Max<T, TResult>(propertyName, where);
        }

        public TResult Min<TResult>(string propertyName, IWhereGetter where)
        {
            return this.DaoTemplate.Min<T, TResult>(propertyName, where);
        }


        public TResult Avg<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.DaoTemplate.Avg<T, TResult>(propertyName, where);
        }

        public TResult Sum<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.DaoTemplate.Sum<T, TResult>(propertyName, where);
        }

        public TResult Count<TResult>(string propertyName, IWhereGetter where = null)
        {
            return this.DaoTemplate.Count<T, TResult>(propertyName, where);
        }

        public void SaveChange()
        {
            this.DaoTemplate.SaveChange();
        }



        public IList<T> Top(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null)
        {
            return this.DaoTemplate.Top<T>(firstIndex, maxSize, orderByGetter, where);
        }


        public IList<T> FindBySql(string sql)
        {
            return this.DaoTemplate.FindBySql<T>(sql);
        }

        public int Execute(string sql)
        {
            return this.DaoTemplate.Execute(sql);
        }
    }
}
