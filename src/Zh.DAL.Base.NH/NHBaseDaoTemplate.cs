using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define;
using NHibernate;
using NHibernate.Criterion;
using Zh.DAL.Base.Define.Helpers;
using Zh.DAL.Base.NH.Helpers;
using Zh.DAL.Base.Define.Entities;
using Zh.Framework.Entities;
using Zh.DAL.Base.Define.Query;
using Spring.Data.NHibernate.Generic.Support;
using Zh.Framework.Tools;
using Zh.DAL.Base.NH.Transactions;
using Spring.Objects.Factory;
using Spring.Data.NHibernate;
using Spring.Transaction;
using Spring.Transaction.Support;
using NHibernate.Transform;

namespace Zh.DAL.Base.NH
{
    public class NHBaseDaoTemplate : HibernateDaoSupport, IBaseDaoTemplate, IInitializingObject
    {
        public Guid id = Guid.Empty;
        public void AfterPropertiesSet()
        {
            if (id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }
            base.AfterPropertiesSet();
        }
        IClassMappingHelper _ClassMappingHelper;
        /// <summary>
        /// 注入的类映射帮助类
        /// </summary>
        public IClassMappingHelper ClassMappingHelper
        {
            get
            {
                if (_ClassMappingHelper == null)
                {
                    throw new Exception("请注入类映射帮助类");
                }
                return _ClassMappingHelper;
            }
            set
            {
                this._ClassMappingHelper = value;
            }
        }
        /// <summary>
        /// 注入事务管理
        /// </summary>
        AbstractPlatformTransactionManager PlatformTransactionManager { get; set; }



        public T Insert<T>(T entity) where T : class
        {
            var id = this.HibernateTemplate.Save(entity);
            var classMetadata = this.SessionFactory.GetClassMetadata(typeof(T));
            classMetadata.SetIdentifier(entity, id, EntityMode.Poco);
            return entity;
        }

        public T InsertOrUpdate<T>(T entity) where T : class
        {
            var newEntity = (T)this.Session.SaveOrUpdateCopy(entity);

            return newEntity;
        }

        public T Update<T>(T entity) where T : class
        {
            var id = this.ClassMappingHelper.GetIdentifierPropertyValue(entity);
            var cacheEntity = this.HibernateTemplate.Get<T>(id);
            if (cacheEntity != null)
            {
                this.Session.Merge(entity);
                //this.HibernateTemplate.Evict(cacheEntity);
            }
            else
            {
                this.HibernateTemplate.Update(entity);
            }

            return entity;
        }

        public T Delete<T>(object id) where T : class
        {
            var entity = this.FindById<T>(id);
            if (entity == null)
            {
                return null;
            }

            this.HibernateTemplate.Delete(entity);

            return entity;
        }

        public T Delete<T>(T entity) where T : class
        {
            this.HibernateTemplate.Delete(entity);

            return entity;
        }

        public T FindById<T>(object id) where T : class
        {
            return this.HibernateTemplate.Get<T>(id);
        }



        public IList<T> FindByProperties<T>(IWhereGetter where, IOrderByGetter orderByGetter = null) where T : class
        {
            var iCriteria = this.Session.CreateCriteria<T>();

            iCriteria = QueryParameterHelper.Add(iCriteria, where);

            iCriteria = QueryParameterHelper.AddOrder(iCriteria, orderByGetter);

            var list = iCriteria.List<T>();

            return list;
        }

        public GenericPageResult<T> Page<T>(IOrderByGetter orderByGetter, IWhereGetter where, int pageIndex = 1, int pageSize = 10)
             where T : class
        {
            var iCriteria = this.Session.CreateCriteria<T>();
            pageIndex = pageIndex == 0 ? 1 : pageIndex;
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var total = ICriteriaHelper.Count(iCriteria);
            iCriteria.SetMaxResults(pageSize);
            iCriteria.SetFirstResult(pageSize * (pageIndex - 1));
            iCriteria = QueryParameterHelper.AddOrder(iCriteria, orderByGetter.OrderBys);
            var list = iCriteria.List<T>();
            GenericPageResult<T> resultData = new GenericPageResult<T>()
            {
                Data = list,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Total = total
            };

            return resultData;
        }


        public IList<T> FindAll<T>(IOrderByGetter orderBys = null) where T : class
        {
            var iCriteria = this.Session.CreateCriteria<T>();

            if (orderBys == null)
            {
                return this.HibernateTemplate.LoadAll<T>();
            }
            iCriteria = QueryParameterHelper.AddOrder(iCriteria, orderBys);
            return iCriteria.List<T>();
        }


        public IList<T> FindByProperty<T>(string propertyName, object value, IOrderByGetter orderByGetter = null) where T : class
        {
            return this.FindByProperties<T>(Where.Create().Eq(propertyName, value), orderByGetter);
        }

        public T FirstOrDefault<T>(string propertyName, object value, IOrderByGetter orderByGetter = null) where T : class
        {
            return this.FirstOrDefault<T>(Where.Create().Eq(propertyName, value), orderByGetter);
        }

        public T FirstOrDefault<T>(IWhereGetter where, IOrderByGetter orderByGetter = null) where T : class
        {
            var list = this.FindByProperties<T>(where, orderByGetter);
            if (ToolFactory.CreateIValidatorTool().IsEmpty(list)) return null;
            return list[0];
        }

        public Define.Transactions.ITransaction GetCurrentTransaction()
        {
            return new BaseTransaction(PlatformTransactionManager);
        }


        public TResult Max<TEntity, TResult>(string propertyName, IWhereGetter where) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();

            iCriteria.SetProjection(Projections.Max(propertyName));
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var result = iCriteria.UniqueResult<TResult>();
            return result;
        }

        public TResult Min<TEntity, TResult>(string propertyName, IWhereGetter where) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();

            iCriteria.SetProjection(Projections.Min(propertyName));
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var result = iCriteria.UniqueResult<TResult>();
            return result;
        }
        public TResult Avg<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();

            iCriteria.SetProjection(Projections.Avg(propertyName));
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var result = iCriteria.UniqueResult<TResult>();
            return result;
        }
        public TResult Sum<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();

            iCriteria.SetProjection(Projections.Sum(propertyName));
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var result = iCriteria.UniqueResult<TResult>();
            return result;
        }
        public TResult Count<TEntity, TResult>(string propertyName, IWhereGetter where = null) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();

            iCriteria.SetProjection(Projections.Count(propertyName));
            iCriteria = QueryParameterHelper.Add(iCriteria, where);
            var result = iCriteria.UniqueResult<TResult>();
            return result;
        }

        public IList<TEntity> Top<TEntity>(int firstIndex, int maxSize, IOrderByGetter orderByGetter, IWhereGetter where = null) where TEntity : class
        {
            var iCriteria = this.Session.CreateCriteria<TEntity>();
            iCriteria.SetFirstResult(firstIndex);
            iCriteria.SetMaxResults(maxSize);
            var list = iCriteria.List<TEntity>();
            return list;
        }

        public void SaveChange()
        {
            this.HibernateTemplate.Flush();
        }

        public IList<T> FindBySql<T>(string sql)
        {
            var sqlQuery = this.Session.CreateSQLQuery(sql);
            sqlQuery.SetResultTransformer(Transformers.AliasToBean<T>());
            var m = sqlQuery.List<T>();
            return m;
        }

        public int Execute(string sql)
        {
            var sqlQuery = this.Session.CreateSQLQuery(sql);

            return sqlQuery.ExecuteUpdate();
        }
    }
}

