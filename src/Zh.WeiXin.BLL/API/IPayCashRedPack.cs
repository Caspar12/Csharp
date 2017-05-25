using System;
using System.Collections.Generic;

using System.Text;
using System.Drawing;
using Zh.Framework.Entities;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信现金红包API
    /// </summary>
    public interface IPayCashRedPack
    {
         /// <summary>
        /// 调用微信发送红包接口
        /// 请求Url	https://api.mch.weixin.qq.com/mmpaymkttransfers/sendredpack
        /// 是否需要证书	是（证书及使用说明详见商户证书）
        /// 请求方式	POST
        /// </summary>
        /// <param name="certFilePath">证书位置</param>
        /// <param name="certPwd">证书密码</param>
        /// <param name="nonce_str">String(32) 随机字符串，不长于32位</param>
        /// <param name="sign">
        /// String(32)	
        /// 详见签名生成算法,https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=4_3
        /// </param>
        /// <param name="mch_billno">
        /// String(28)
        /// 商户订单号（每个订单号必须唯一）
        /// 组成：mch_id+yyyymmdd+10位一天内不能重复的数字。
        /// 接口根据商户订单号支持重入，如出现超时可再调用。</param>
        /// <param name="mch_id">String(32) 微信支付分配的商户号</param>
        /// <param name="wxappid">
        /// 微信分配的公众账号ID（企业号corpid即为此appId）。
        /// 接口传入的所有appid应该为公众号的appid（在mp.weixin.qq.com申请的），
        /// 不能为APP的appid（在open.weixin.qq.com申请的）。
        /// </param>
        /// <param name="send_name">String(32) 红包发送者名称</param>
        /// <param name="re_openid">String(32) 接受红包的用户 用户在wxappid下的openid</param>
        /// <param name="total_amount">付款金额，单位分</param>
        /// <param name="total_num">红包发放总人数,total_num=1</param>
        /// <param name="wishing">String(128) 红包祝福语</param>
        /// <param name="client_ip">String(15) 调用接口的机器Ip地址</param>
        /// <param name="act_name">String(32) 活动名称</param>
        /// <param name="remark">String(256) 备注信息</param>
        /// <returns></returns>
          Entities.SendRedPackResult SendRedPack(string certFilePath, string certPwd,
            string nonce_str, string sign, string mch_billno,
            string mch_id, string wxappid, string send_name, string re_openid, int total_amount,
            int total_num, string wishing, string client_ip, string act_name, string remark);


         /// <summary>
        /// 调用微信发送红包接口
        /// 请求Url	https://api.mch.weixin.qq.com/mmpaymkttransfers/sendredpack
        /// 是否需要证书	是（证书及使用说明详见商户证书）
        /// 请求方式	POST
        /// </summary>
        /// <param name="certFilePath">证书位置</param>
        /// <param name="certPwd">证书密码</param>
        /// <param name="apiSecretKey">API安全密钥,设置路径：微信商户平台(pay.weixin.qq.com)-->账户设置-->API安全-->密钥设置</param>
        /// <param name="mch_billno">
        /// String(28)
        /// 商户订单号（每个订单号必须唯一）
        /// 组成：mch_id+yyyymmdd+10位一天内不能重复的数字。
        /// 接口根据商户订单号支持重入，如出现超时可再调用。</param>
        /// <param name="mch_id">String(32) 微信支付分配的商户号</param>
        /// <param name="wxappid">
        /// 微信分配的公众账号ID（企业号corpid即为此appId）。
        /// 接口传入的所有appid应该为公众号的appid（在mp.weixin.qq.com申请的），
        /// 不能为APP的appid（在open.weixin.qq.com申请的）。
        /// </param>
        /// <param name="send_name">String(32) 红包发送者名称</param>
        /// <param name="re_openid">String(32) 接受红包的用户 用户在wxappid下的openid</param>
        /// <param name="total_amount">付款金额，单位分</param>
        /// <param name="total_num">红包发放总人数,total_num=1</param>
        /// <param name="wishing">String(128) 红包祝福语</param>
        /// <param name="client_ip">String(15) 调用接口的机器Ip地址</param>
        /// <param name="act_name">String(32) 活动名称</param>
        /// <param name="remark">String(256) 备注信息</param>
        /// <returns></returns>
          Entities.SendRedPackResult SendRedPack(string certFilePath, string certPwd,
            string apiSecretKey, string mch_billno,
            string mch_id, string wxappid, string send_name, string re_openid, int total_amount,
            int total_num, string wishing, string client_ip, string act_name, string remark);
    }
}
