using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public class AbstractCompareFilter : AbstractFilter
    {
        public string Property { get; set; }
        public CompareFilterMode CompareFilterMode { get; set; }

    }
}
