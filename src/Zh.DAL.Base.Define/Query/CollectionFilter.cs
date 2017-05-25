using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools;

namespace Zh.DAL.Base.Define.Query
{
    public class CollectionFilter : AbstractFilter, ICollectionFilter
    {
        public List<AbstractFilter> Filters { get; private set; }
        public void AddFilter(AbstractFilter filter)
        {
            List<AbstractFilter> list = new List<AbstractFilter>(1) { filter };
            AddFilter(list);
        }
        public void AddFilter(IEnumerable<AbstractFilter> filters)
        {
            if (ToolFactory.CreateIValidatorTool().IsEmpty(this.Filters))
            {
                this.Filters = new List<AbstractFilter>();
            }
            this.Filters.AddRange(filters);
        } 
    }
}
