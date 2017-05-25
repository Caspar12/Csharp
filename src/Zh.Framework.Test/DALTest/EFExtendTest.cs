using LinqKit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zh.Framework.Test.DAL;

namespace Zh.Framework.Test.DALTest
{
    [TestClass]
    public class EFExtendTest
    {
        [TestMethod]
        public void ExpressionExtendTest()
        {
            DAL.SiBuDbContext context = new DAL.SiBuDbContext();

            var predicate = PredicateBuilder.New<User_Main>(true);

            predicate = predicate.And(p => p.ID == 1);

            predicate = predicate.Or(p => p.ID == 2);

            var q = context.User_Main.AsExpandable().Where(predicate);

            var u = q.ToList();
            var sql = q as ObjectQuery<User_Main>;
            if (sql != null)
            {
                var sql_str = sql.ToTraceString();
            }

            var i = 0;


        }
    }
}
