using System;
using System.Collections.Generic;
using System.Text;
using Spring.Data.NHibernate;
using NHibernate;
using NHibernate.Cfg;

namespace Zh.DAL.Base.NH
{
    public class LocalSessionFactoryObjectThreadSafe : LocalSessionFactoryObject
    {
        static object SyncObj = new object();
        public override void AfterPropertiesSet()
        {
            lock (SyncObj)
            {
                base.AfterPropertiesSet();
            }         
        }
    }
}
