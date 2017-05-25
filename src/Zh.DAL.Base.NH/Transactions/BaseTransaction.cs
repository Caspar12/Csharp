using System;
using System.Collections.Generic;
using System.Text;
using Spring.Data.NHibernate;
using Spring.Transaction;
using Spring.Transaction.Support;


namespace Zh.DAL.Base.NH.Transactions
{
    public class BaseTransaction : Zh.DAL.Base.Define.Transactions.ITransaction
    {
        ITransactionStatus _ITransactionStatus;
        AbstractPlatformTransactionManager _TransactionManager { get; set; }
        public BaseTransaction(AbstractPlatformTransactionManager transactionManager)
        {
            _TransactionManager = transactionManager;
            DefaultTransactionDefinition def = new DefaultTransactionDefinition();
            def.PropagationBehavior = TransactionPropagation.Required;
            _ITransactionStatus = _TransactionManager.GetTransaction(def);            
        }

        public void Commit()
        {
            _TransactionManager.Commit(_ITransactionStatus);
        }

        public void Rollback()
        {
            _TransactionManager.Rollback(_ITransactionStatus);
        }
    }
}
