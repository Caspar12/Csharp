using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Entities
{
    public class GenericApiPageResult<T>

    {
        public IList<T> data { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }
}
