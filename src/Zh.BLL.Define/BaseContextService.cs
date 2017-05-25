using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool;
using Zh.BLL.Define;
using Zh.BLL.Define.ServiceContexts;
using Zh.DAL.Base.Define.Transactions;

namespace Zh.BLL.Base.Define
{
    public abstract class BaseContextService : AbstractBaseService
    {
        protected ServiceContext ServiceContext { get; set; }
     
    }
}
