using System;
using System.Collections.Generic;
using System.Text;
using Zh.DAL.Base.Define.Query;
using NHibernate.Criterion;
using Zh.DAL.Base.Define.Helpers;
using NHibernate;
using Zh.Framework.Tools;

namespace Zh.DAL.Base.NH.Helpers
{
    public static class QueryParameterHelper
    {


        public static ICriterion ToICriterion(IWhereGetter where)
        {          
            ICriterion leftICriterion = null;
            var enumerator = where.Filter.Filters.GetEnumerator();
            while (enumerator.MoveNext())
            {
                  leftICriterion = ConcatICriterionByFilters(leftICriterion, enumerator);
             
            }
            return leftICriterion;
        }
        static ICriterion ConcatICriterionByFilters(ICriterion leftCriterion, List<AbstractFilter>.Enumerator filterEnumerator)
        {
            var currentFilter = filterEnumerator.Current;
            var currentFilterType = currentFilter.GetType();
            ICriterion rightICriterion = null;
            if (currentFilter is CompareValueFilter)
            {
                var filter = (CompareValueFilter)currentFilter;
                rightICriterion = ToICriterion(filter);
                return leftCriterion != null ? Restrictions.And(leftCriterion, rightICriterion) : rightICriterion;
            }
            else if (currentFilter is ComparePropertyFilter)
            {
                var filter = (ComparePropertyFilter)currentFilter;
                rightICriterion = ToICriterion(filter);
                return leftCriterion != null ? Restrictions.And(leftCriterion, rightICriterion) : rightICriterion;
            }
            else if (currentFilter is LogicFilter)
            {
                var filter = (LogicFilter)currentFilter;
                var isHasNextFilter = filterEnumerator.MoveNext();
                if (isHasNextFilter == false)
                {
                    return rightICriterion;
                }
                rightICriterion = ConcatICriterionByFilters(rightICriterion, filterEnumerator);
                if (rightICriterion == null)
                {
                    return null;
                }
                if (filter.Mode == LogicFilterMode.And)
                {
                    return leftCriterion != null ? Restrictions.And(leftCriterion, rightICriterion) : rightICriterion;
                }
                else
                {
                    return leftCriterion != null ? Restrictions.Or(leftCriterion, rightICriterion) : rightICriterion;
                }
            }
            else if (currentFilter is ICollectionFilter)
            {
                var filter = (ICollectionFilter)currentFilter;
                var tFilterEnumerator = filter.Filters.GetEnumerator();
                return ConcatICriterionByFilters(rightICriterion, tFilterEnumerator);
            }
            else
            {
                throw new Exception(string.Format("请实现类型{0}转换方法", currentFilterType.FullName));
            }
        }

        static ICriterion ToICriterion(CompareValueFilter compareValueFilter)
        {
            var property = Property.ForName(compareValueFilter.Property);
            ICriterion result = null;
            switch (compareValueFilter.CompareFilterMode)
            {
                case CompareFilterMode.Eq:
                    result = property.Eq(compareValueFilter.Value);
                    break;
                case CompareFilterMode.EqNot:
                    result = Restrictions.Not(property.Eq(compareValueFilter.Value));
                    break;
                case CompareFilterMode.Ge:
                    result = property.Ge(compareValueFilter.Value);
                    break;
                case CompareFilterMode.Gt:
                    result = property.Gt(compareValueFilter.Value);
                    break;
                case CompareFilterMode.Le:
                    result = property.Le(compareValueFilter.Value);
                    break;
                case CompareFilterMode.Lt:
                    result = property.Lt(compareValueFilter.Value);
                    break;
                case CompareFilterMode.Like:
                    result = property.Like(compareValueFilter.Value.ToString(), MatchMode.Anywhere);
                    break;
                case CompareFilterMode.LikeStart:
                    result = property.Like(compareValueFilter.Value.ToString(), MatchMode.Start);
                    break;
                case CompareFilterMode.LikeEnd:
                    result = property.Like(compareValueFilter.Value.ToString(), MatchMode.End);
                    break;
                case CompareFilterMode.LikeExact:
                    result = property.Like(compareValueFilter.Value.ToString(), MatchMode.Exact);
                    break;
                default:
                    throw new Exception(string.Format("请实现类型{0}转换方法", typeof(ComparePropertyFilter).FullName));
            }
            return result;
        }
        static ICriterion ToICriterion(ComparePropertyFilter comparePropertyFilter)
        {
            var property = Property.ForName(comparePropertyFilter.Property);
            ICriterion result = null;
            switch (comparePropertyFilter.CompareFilterMode)
            {
                case CompareFilterMode.Eq:
                    result = property.EqProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.EqNot:
                    result = property.NotEqProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.Ge:
                    result = property.GeProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.Gt:
                    result = property.GtProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.Le:
                    result = property.LeProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.Lt:
                    result = property.LtProperty(comparePropertyFilter.CompareProperty);
                    break;
                case CompareFilterMode.Like:
                    result = property.Like(comparePropertyFilter.CompareProperty, MatchMode.Anywhere);
                    break;
                case CompareFilterMode.LikeStart:
                    result = property.Like(comparePropertyFilter.CompareProperty, MatchMode.Start);
                    break;
                case CompareFilterMode.LikeEnd:
                    result = property.Like(comparePropertyFilter.CompareProperty, MatchMode.End);
                    break;
                case CompareFilterMode.LikeExact:
                    result = property.Like(comparePropertyFilter.CompareProperty, MatchMode.Exact);
                    break;
                default:
                    throw new Exception(string.Format("请实现类型{0}转换方法", typeof(ComparePropertyFilter).FullName));
            }
            return result;
        }
        public static Order ToOrder(Define.Query.OrderBy orderBy)
        {
            if (orderBy.OrderMode == OrderMode.Asc)
            {
                return Order.Asc(orderBy.Property);
            }
            else
            {
                return Order.Desc(orderBy.Property);
            }
        }
        public static ICriteria AddOrder(ICriteria iCriteria, IEnumerable<OrderBy> orderBys)
        {
            if (ToolFactory.CreateIValidatorTool().IsEmpty(orderBys))
            {
                return iCriteria;
            }
            foreach (var orderBy in orderBys)
            {
                iCriteria.AddOrder(ToOrder(orderBy));
            }
            return iCriteria;
        }
        public static ICriteria AddOrder(ICriteria iCriteria, IOrderByGetter orderBys)
        {
            if (orderBys == null)
            {
                return iCriteria;
            }
            return AddOrder(iCriteria, orderBys.OrderBys);
        }

        public static ICriteria Add(ICriteria iCriteria, IWhereGetter where)
        {
            if (where == null || where.Filter == null || where.Filter.Filters == null || where.Filter.Filters.Count == 0)
            {
                return iCriteria;
            }
            ICriterion leftICriterion = null;
            leftICriterion = ToICriterion(where);
            if (leftICriterion != null)
            {
                iCriteria.Add(leftICriterion);
            }
            return iCriteria;
           
        }
    }
}
