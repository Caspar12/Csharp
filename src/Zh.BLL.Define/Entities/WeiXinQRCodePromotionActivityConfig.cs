using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.BLL.Entities
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
        public bool IsFollowPublicWeiXinAccountHasPoints { get; set; }
        /// <summary>
        /// 关注微信号获得的积分的方法类型
        /// </summary>
        public GetFollowPulicWeiXinAccountPointsEnum GetFollowPulicWeiXinAccountPointsType { get; set; }
        /// <summary>
        /// 关注微信公众号获取的积分数量
        /// </summary>
        public int FollowPoints { get; set; }
        /// <summary>
        /// 红色发送者名称
        /// </summary>
        public string RedPackSendName
        {
            get;
            set;
        }
        /// <summary>
        /// 红包祝福语
        /// </summary>
        public string RedPackWishing { get; set; }
        /// <summary>
        /// 红包发送Ip
        /// </summary>
        public string RedPackClientIP { get; set; }
        /// <summary>
        /// 红包活动名称
        /// </summary>
        public string RedPackActivityName { get; set; }
        /// <summary>
        /// 红包备注
        /// </summary>
        public string RedPackRemark { get; set; }
        /// <summary>
        /// 证书密码
        /// </summary>
        public string CertFilePwd { get; set; }

        /// <summary>
        /// 默认兑换时候消费积分
        /// </summary>
        public int DefaultUsePoints { get; set; }
        /// <summary>
        /// 默认兑换时候兑换金额,单位分
        /// </summary>
        public int DefaultExchangeMenoey { get; set; }
    }
}
