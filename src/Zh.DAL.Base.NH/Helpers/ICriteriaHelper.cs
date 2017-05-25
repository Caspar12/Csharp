using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace Zh.DAL.Base.NH.Helpers
{
    public static class ICriteriaHelper
    {
        public static int Count(ICriteria iCriteria)
        {
            var cloneCriteria = CriteriaTransformer.Clone(iCriteria);
            cloneCriteria.SetProjection(Projections.RowCount());
            var total = cloneCriteria.UniqueResult<int>();           
            return total;
        }
    }
}
