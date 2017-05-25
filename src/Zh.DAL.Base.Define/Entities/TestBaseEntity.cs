using System;
using System.Collections.Generic; 
using System.Text;
using Zh.DAL.Base.Define.Query;

namespace Zh.DAL.Base.Define.Entities
{
    public class TestBaseEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public void a()
        {
            IBaseDao<TestBaseEntity> l;
        
            

        }
    }
}
