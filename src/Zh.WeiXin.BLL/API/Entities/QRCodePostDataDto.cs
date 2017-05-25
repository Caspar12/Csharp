using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 创建二维码Post的数据结构
    /// </summary>
    public class QRCodePostDataDto
    {
        internal QRCodePostDataDto() { }
        /// <summary>
        /// 二维码类型，QR_SCENE为临时,QR_LIMIT_SCENE为永久,QR_LIMIT_STR_SCENE为永久的字符串参数值
        /// </summary>
        public string action_name { get; set; }
        /// <summary>
        /// 该二维码有效时间，以秒为单位。 最大不超过2592000（即30天），此字段如果不填，则默认有效期为30秒。
        /// </summary>
        public int? expire_seconds { get; set; }
        /// <summary>
        /// 二维码详细信息
        /// </summary>
        public AbstractQRCodeActionInfo action_info { get; set; }
    }
}
