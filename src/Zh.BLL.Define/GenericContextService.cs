using System;
using System.Collections.Generic;
using System.Text;
using Zh.BLL.Base.Define;
using Zh.BLL.Define.ServiceContexts;
namespace Zh.BLL.Define
{
    public class GenericContextService<TDto, TDbEntity> : BaseService<TDto, TDbEntity>
        where TDto :class
        where TDbEntity : class
    {
        protected ServiceContext ServiceContext { get; set; }
    }
}
