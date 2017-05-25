using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 获取AccessToken方法结果数据结构
    /// </summary>
  
    [SerializableAttribute]
    public class GetAccessTokenResult
    {
        /// <summary>
        /// AccessToken
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// 过期时间,单位:秒
        /// </summary>
        public int expires_in { get; set; }
    }
}
