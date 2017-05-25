using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools;

namespace Zh.DAL.Base.Define.Query
{
    public class Where : IWhereGetter 
    {
        public Where()
        {
            this.Filter = new CollectionFilter();
        }
        ICollectionFilter IWhereGetter.Filter
        {
            get { return Filter; }
        }

        CollectionFilter Filter { get; set; }

        public static Where Create()
        {
            return new Where();
        }

        #region 添加查询条件帮助方法
       
        public Where Eq(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.Eq
            });
            return this;
        }
        public Where EqIfNotNull(string property, object value)
        {
            if (value == null)
            {
                return this;
            }
            if (value is string)
            {
                if (value != null)
                {
                    return this.Eq(property, value);
                }
                return this;
            }
            else
            {
                throw new Exception(string.Format("还没有实现EqIfNotNull方法类型为{0}的方法", value.GetType().FullName));
            }
        }
        public Where EqNot(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.EqNot
            });
            return this;
        }
        public Where Lt(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.Lt
            });
            return this;
        }
        public Where Le(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.Le
            });
            return this;
        }
        public Where Gt(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.Gt
            });
            return this;
        }
        public Where Ge(string property, object value)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = CompareFilterMode.Ge
            });
            return this;
        }

        public Where Like(string property, object value, LikeMatchMode matchMode = LikeMatchMode.Like)
        {
            this.Filter.AddFilter(new CompareValueFilter()
            {
                Property = property,
                Value = value,
                CompareFilterMode = (CompareFilterMode)(int)matchMode
            });
            return this;
        }

        #endregion
    }
}
