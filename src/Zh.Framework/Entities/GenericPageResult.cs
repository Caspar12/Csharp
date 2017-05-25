using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Entities
{
    public class GenericPageResult<T>
    {
        public IList<T> Data { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Total { get; set; }        
    }
}
