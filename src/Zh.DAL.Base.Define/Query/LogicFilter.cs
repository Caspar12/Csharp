using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public abstract class LogicFilter : AbstractFilter
    {
        public LogicFilterMode Mode { get; set; }
    }
}
