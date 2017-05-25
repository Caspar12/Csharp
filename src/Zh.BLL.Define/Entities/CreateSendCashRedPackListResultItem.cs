using System;
using System.Collections.Generic;
using System.Text;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.BLL.Define.Entities
{
    public class CreateSendCashRedPackListResultItem
    {
        public WeiXinAccount WeiXinAccount { get; set; }
        public string Remark { get; set; }
        public bool IsSuccess { get; set; }
        public int UsePoints { get; set; }
        public int ExchangeMoney { get; set; }
        public string OpenId { get; set; }
    }
}
