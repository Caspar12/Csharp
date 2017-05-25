using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Define.Entities;

namespace Zh.DAL.Define.Contracts
{
    public partial interface IComCountDao
    {
        Com_Count FirstOrDefaultByTargetIdAndCategoryId(Guid targetId, string categoryId);
    }
}
