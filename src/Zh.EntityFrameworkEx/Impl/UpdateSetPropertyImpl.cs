using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Zh.EntityFrameworkEx;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using Zh.EntityFrameworkEx.Utils;

namespace Zh.EntityFrameworkEx.Impl
{
    public class UpdateSetPropertyImpl<TEntity> : UpdateSetProperty<TEntity> where TEntity : class, new()
    {
        private DbContext _DbContext;
        private TEntity _Entity;


        TEntity UpdateSetProperty<TEntity>.Entity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public UpdateSetPropertyImpl(DbContext dbContext, TEntity entity)
        {
            this.Init(dbContext, entity);
        }
        public UpdateSetPropertyImpl(DbContext dbContext, object idValue)
        {
            TEntity entity = new TEntity();
            EntityFrameworkHelper.SetPrimaryKeyPropertyValue<TEntity>(entity, idValue);
            this.Init(dbContext, entity);
        }
        private void Init(DbContext dbContext, TEntity entity)
        {

            this._DbContext = dbContext;
            this._Entity = entity;
            var localEntity = this._DbContext.Set<TEntity>().Local.Where(p => EntityFrameworkHelper.EqualsPrimaryKeys(p, this._Entity)).FirstOrDefault();
            if (localEntity != null)
            {
                this._Entity = localEntity;
            }
            else
            {
                this._DbContext.Set<TEntity>().Attach(this._Entity);
            }

        }

        public void SaveChanges()
        {
            _DbContext.SaveChanges();
        }

        public UpdateSetProperty<TEntity> SetProperty<TProperty>(System.Linq.Expressions.Expression<Func<TEntity, TProperty>> property, TProperty value)
        {
            var dbPropertyEntry = this._DbContext.Entry<TEntity>(this._Entity).Property(property);
            dbPropertyEntry.OriginalValue = dbPropertyEntry.CurrentValue;
            dbPropertyEntry.CurrentValue = value;
            dbPropertyEntry.IsModified = true;
            return this;
        }
    }
}
