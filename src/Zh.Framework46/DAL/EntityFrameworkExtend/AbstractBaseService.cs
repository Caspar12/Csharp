using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zh.Framework.Tools;
using Zh.Framework.Tools.ValidatorTool;
using Zh.Framework46.DAL.EntityFrameworkExtend;

namespace Zh.Framework.EntityFrameworkExtend
{
    public abstract class AbstractBaseService<TDbContext> : AbstractService where TDbContext : DbContext, new()
    {
        public AbstractBaseService() : base(new TDbContext())
        {

        }
        TDbContext _DbContext;
        protected TDbContext DbContext
        {
            get
            {
                if (this.GetDbContext() == null)
                {
                    SetDbContext(new TDbContext());
                }

                return _DbContext = (TDbContext)GetDbContext(); ;
            }
        }

    }
}
