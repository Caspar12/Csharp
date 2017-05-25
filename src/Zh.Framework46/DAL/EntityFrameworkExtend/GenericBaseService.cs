using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Zh.Framework.EntityFrameworkExtend
{
    public class GenericBaseService<T, TDbContext> : AbstractBaseService<TDbContext> where T : class
        where TDbContext : DbContext, new()
    {

        public T FindById(object id)
        {
            return this.FindById<T>(id);
        }
    }
}
