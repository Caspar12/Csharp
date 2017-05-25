using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define;
using Zh.DAL.Define.Entities;
using Zh.DAL.Define.Contracts;
using Zh.DAL.Base.Define.Query;

namespace Zh.DAL.Define.Contracts.Imp
{
    public partial class ComCountDao : BaseDao<Com_Count>, IComCountDao
    {
        public Com_Count FirstOrDefaultByTargetIdAndCategoryId(Guid targetId, string categoryId)
        {   
            var list = this.FindByProperties(Where.Create().Eq("TargetId", targetId).Eq("CategoryId", categoryId));
            if (IValidatorTool.IsEmpty(list))
            {
                return null;
            }
            return list[0];
        }
    }
}
