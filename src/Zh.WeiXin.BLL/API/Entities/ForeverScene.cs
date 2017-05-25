using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 二维码临时场景Scene数据结构
    /// </summary>
    public class ForeverScene : AbstractScene
    {
        /// <summary>
        /// 场景值ID（字符串形式的ID），字符串类型，长度限制为1到64，仅永久二维码支持此字段
        /// </summary>
        public string scene_str { get; set; }
    }
}
