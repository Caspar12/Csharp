using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BLL.Imp.WeiXin.Entities
{
    /// <summary>
    /// 微信二维码推广活动配置数据结构
    /// </summary>
    public class WeiXinQRCodePromotionActivityConfig
    {
        /// <summary>
        /// 二维码类型
        /// </summary>
        public string QRCodeActionName { get; set; }
        /// <summary>
        /// 是否临时二维码
        /// </summary>
        public bool IsTemporary { get; set; }
        /// <summary>
        /// 新创建临时二维码图片过期时间,单位秒
        /// </summary>
        public int NewTemporaryQRCodeImageExpireInSeconds { get; set; }
        /// <summary>
        /// 关注微信号获得的积分
        /// </summary>
        public bool FollowPublicWeiXinAccountPoints { get; set; }
        /// <summary>
        /// 关注微信号获得的积分的方法类型
        /// </summary>
        public GetFollowPulicWeiXinAccountPointsEnum GetFollowPulicWeiXinAccountPointsType { get; set; }
    }
}
