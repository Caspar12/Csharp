using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public class OrderByHelper : IOrderByGetter
    {
        IList<OrderBy> _OrderBys = new List<OrderBy>();
        public IEnumerable<OrderBy> OrderBys
        {
            get { return _OrderBys; }
        }
        public static OrderByHelper Create()
        {
            return new OrderByHelper();
        }
        public OrderByHelper Asc(string propertyName)
        {
            _OrderBys.Add(new OrderBy()
            {
                Property = propertyName,
                OrderMode = OrderMode.Asc
            });
            return this;
        }

        public OrderByHelper Desc(string propertyName)
        {
            _OrderBys.Add(new OrderBy()
            {
                Property = propertyName,
                OrderMode = OrderMode.Des
            });
            return this;
        }
    }
}
