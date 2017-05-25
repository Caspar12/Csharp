using System;
using System.Collections.Generic;
using System.Text;
using Spring.Data.NHibernate.Generic;
using Spring.Objects.Factory;

namespace Zh.DAL.Base.NH
{
    public class NHHibernateTemplate : HibernateTemplate, IInitializingObject
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
    }
}
