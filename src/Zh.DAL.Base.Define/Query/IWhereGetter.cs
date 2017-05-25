using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Query
{
    public interface IWhereGetter
    {
        ICollectionFilter Filter { get; }
        
    }
}
