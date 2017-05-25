using System;
using System.Collections.Generic;
 
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    public class GetJsTickectResultDto : ErrorResultDto
    {
        public string ticket { get; set; }
        public string expires_in { get; set; }
    }
}
