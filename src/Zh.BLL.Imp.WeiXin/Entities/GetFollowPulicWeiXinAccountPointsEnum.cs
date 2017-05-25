using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BLL.Imp.WeiXin.Entities
{
    /// <summary>
    /// 关注微信号获得的积分的方法类型
    /// </summary>
    public enum GetFollowPulicWeiXinAccountPointsEnum
    {
        /// <summary>
        /// 账号必须是全局记录唯一并且是新的
        /// </summary>
        NewUnique = 0,
        /// <summary>
        /// 账号必须是新的
        /// </summary>
        New
    }
}
