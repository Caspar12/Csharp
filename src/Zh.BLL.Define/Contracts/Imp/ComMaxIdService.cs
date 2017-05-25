
using System;
using System.Collections;
using System.Collections.Generic;
using Zh.DAL.Define.Entities;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Query;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.Entities;
using Zh.DAL.Define.DbContexts;
using Zh.Framework.Entities;
namespace Zh.BLL.Define.Contracts.Imp
{
    public partial class ComMaxIdService : GenericContextService<ComMaxIdDto, Com_MaxId>, IComMaxIdService
    {
        public long CreateNext(Guid id)
        {

            var m = this.DbContext.IComMaxIdDao.FindById(id);
            if (m == null)
            {
                m = new Com_MaxId()
                {
                    ID = id,
                    MaxId = 1
                };
            }
            else
            {
                m.MaxId += 1;
            }
            this.DbContext.IComMaxIdDao.InsertOrUpdate(m);

            return m.MaxId;
        }

        public long GetMax(Guid id)
        {
            var m = this.DbContext.IComMaxIdDao.FindById(id);
            return m.MaxId;
        }
    }
}
