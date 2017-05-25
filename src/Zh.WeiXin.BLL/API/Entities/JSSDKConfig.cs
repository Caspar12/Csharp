using System;
using System.Collections.Generic;

using System.Text;

namespace Zh.WeiXin.BLL.API.JSSDK.Entities
{
    public class JSSDKConfig
    {
   
        public string Nonce { get; set; }
        public long Timestamp { get; set; }
        public string Signature { get; set; }
        public string JsTickect { get; set; }
    }
}
