using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BLL.Define.Entities
{
    public class CreateSendCashRedPackListResult
    {
        public CreateSendCashRedPackListResult()
        {
            CreateSendCashRedPackListResultItems = new List<CreateSendCashRedPackListResultItem>();
        }
        public int TotalCount { get; set; }
        public int SuccessCount { get; set; }
        public int FailureCount
        {
            get
            {
                return TotalCount - SuccessCount;
            }
        }
        public IList<CreateSendCashRedPackListResultItem> CreateSendCashRedPackListResultItems { get; set; }
    }
}
