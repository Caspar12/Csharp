using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 抽象二维码详细信息
    /// </summary>
    public abstract class AbstractQRCodeActionInfo
    {
        /// <summary>
        /// 二维码场景Scene数据结构
        /// </summary>
        public AbstractScene scene { get; set; }

    }
}
