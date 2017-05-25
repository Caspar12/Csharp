using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.DAL.Base.Define.Transactions
{
    public interface ITransaction
    {
        void Commit();
        void Rollback();
    }
}
