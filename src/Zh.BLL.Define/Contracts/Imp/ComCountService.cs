/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据接口契约文件
 * 文件由模板生成
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;

namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class ComCountService : GenericContextService<ComCountDto, Com_Count>, IComCountService
    {
        public Framework.Entities.GenericExecResult<ComCountDto> FindFirstOrDefaultByTargetIdAndCategoryId(Guid targetId, string categoryId, string table = null)
        {
            throw new NotImplementedException();
        }

        public Framework.Entities.GenericExecResult<IList<ComCountDto>> FindByTargetId(Guid targetId, string table = null)
        {
            throw new NotImplementedException();
        }

        public Framework.Entities.GenericExecResult<ComCountDto> Add(Guid id, int count = 1, string table = null)
        {
            throw new NotImplementedException();
        }

        public Framework.Entities.GenericExecResult<ComCountDto> Add(Guid targetId, string categoryId = null, int count = 1, string table = null)
        {
            throw new NotImplementedException();
        }
    }
}
