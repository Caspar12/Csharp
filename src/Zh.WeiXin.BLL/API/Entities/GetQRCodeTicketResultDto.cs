using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 获取二维码Ticket结果数据结构
    /// </summary>
    public class GetQRCodeTicketResultDto
    {
        /// <summary>
        /// 二维码Ticket
        /// </summary>
        public string ticket { get; set; }
        /// <summary>
        /// 失效时间,单位秒
        /// </summary>
        public int expire_seconds { get; set; }
        /// <summary>
        /// 二维码图片解析后的地址
        /// </summary>
        public string url { get; set; }
    }
}
