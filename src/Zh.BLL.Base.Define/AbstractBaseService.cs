using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.ValidatorTool;
using Zh.DAL.Base.Define;
using Zh.DAL.Base.Define.Transactions;

namespace Zh.BLL.Base.Define
{
    public abstract class AbstractBaseService
    {
        protected IValidatorTool IValidatorTool { get; set; }

        protected Zh.DAL.Define.DbContexts.DbContext DbContext { get; set; }
        /// <summary>
        /// 只用作注入基础Dao数据访问接口模板,只在数据访问层中使用
        /// </summary>
        protected IBaseDaoTemplate IBaseDao { get; set; }
        /// <summary>
        /// 获取当前存在的事务,否则创建一个新的事务,过期方法
        /// </summary>
        /// <returns></returns>
        private ITransaction GetCurrentTransaction()
        {
            return this.IBaseDao.GetCurrentTransaction();
        }
    }
}
