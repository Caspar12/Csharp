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
        public UpdateSetPropertyImpl(DbContext dbContext, TEntity entity)
        {
            this.Init(dbContext, entity);
        }
        public UpdateSetPropertyImpl(DbContext dbContext, object idValue)
        {
            TEntity entity = new TEntity();
            EntityFrameworkHelper.setPrimaryKeyPropertyValue<TEntity>(entity, idValue);
            this.Init(dbContext, entity);
        }
        private void Init(DbContext dbContext, TEntity entity)
        {

            this._DbContext = dbContext;
            this._Entity = entity;
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
            dbPropertyEntry.EntityEntry.State = EntityState.Modified;

            return this;
        }
    }
}
