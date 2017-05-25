using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public enum CompareFilterMode
    {
        Eq = 0,
        EqNot = 1,
        Lt = 2,
        Le = 3,
        Gt = 4,
        Ge = 5,
        Like = 6,
        LikeStart = 7,
        LikeEnd = 8,
        LikeExact = 9,
        In = 10,
        InNot = 11,
        IsNull = 12,
        IsNullNot = 13
    }
}
