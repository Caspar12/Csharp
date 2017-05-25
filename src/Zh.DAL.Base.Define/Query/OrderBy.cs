using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public class OrderBy : IOrderByGetter
    {
        public string Property { get; set; }
        public OrderMode OrderMode { get; set; }

        public IEnumerable<OrderBy> OrderBys
        {
            get { return new OrderBy[] { this }; }
        }
    }
}
