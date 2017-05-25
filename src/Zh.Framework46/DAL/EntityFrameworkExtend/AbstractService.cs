using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zh.Framework.Tools;
using Zh.Framework.Tools.ValidatorTool;

namespace Zh.Framework46.DAL.EntityFrameworkExtend
{
    public class AbstractService
    {
        public AbstractService(DbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        DbContext DbContext;

        public void SetDbContext(DbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        public DbContext GetDbContext()
        {
            return this.DbContext;
        }
        IValidatorTool _IValidatorTool;
        protected IValidatorTool ValidatorTool
        {
            get
            {
                if (_IValidatorTool == null) _IValidatorTool = ToolFactory.CreateIValidatorTool();
                return _IValidatorTool;
            }
        }
        protected void Transaction(Action func)
        {
            this.Transaction<bool>(IsolationLevel.ReadCommitted, () =>
            {
                func();
                return true;
            });
        }
        protected void Transaction(System.Data.IsolationLevel isolationLevel, Action func)
        {
            this.Transaction<bool>(isolationLevel, () =>
            {
                func();
                return true;
            });
        }
        protected T Transaction<T>(Func<T> func)
        {
            return this.Transaction<T>(IsolationLevel.ReadCommitted, func);
        }
        protected T Transaction<T>(System.Data.IsolationLevel isolationLevel, Func<T> func)
        {
            var trans = this.DbContext.Database.CurrentTransaction;
            if (trans == null)
            {
                using (trans = this.DbContext.Database.BeginTransaction(isolationLevel))
                {
                    try
                    {
                        var result = func();
                        this.DbContext.SaveChanges();
                        trans.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
            }
            else
            {
                return func();
            }
        }

        protected T FindById<T>(object id) where T : class
        {
            var r = this.DbContext.Set<T>().Find(id);
            return r;
        }
        protected bool Exist<T>(object id) where T : class
        {
            var r = this.FindById<T>(id);
            return r != null;
        }
    }
}
