using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Zh.WeiXin.BLL.Helpers;
using Zh.Framework.Tools;
using Zh.Net.Http;
using Zh.WeiXin.BLL.API.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace Zh.WeiXin.BLL.API.Imp
{
    /// <summary>
    /// 微信现金红包API
    /// </summary>
    public class PayCashRedPack : IPayCashRedPack
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
        public Entities.SendRedPackResult SendRedPack(string certFilePath, string certPwd,
            string nonce_str, string sign, string mch_billno,
            string mch_id, string wxappid, string send_name, string re_openid, int total_amount,
            int total_num, string wishing, string client_ip, string act_name, string remark)
        {
            //<xml>
            //     <sign><![CDATA[E1EE61A91C8E90F299DE6AE075D60A2D]]></sign>
            //     <mch_billno><![CDATA[0010010404201411170000046545]]></mch_billno>
            //     <mch_id><![CDATA[888]]></mch_id>
            //     <wxappid><![CDATA[wxcbda96de0b165486]]></wxappid>
            //     <send_name><![CDATA[send_name]]></send_name>
            //     <re_openid><![CDATA[onqOjjmM1tad-3ROpncN-yUfa6uI]]></re_openid>
            //     <total_amount><![CDATA[200]]></total_amount>
            //     <total_num><![CDATA[1]]></total_num>
            //     <wishing><![CDATA[恭喜发财]]></wishing>
            //     <client_ip><![CDATA[127.0.0.1]]></client_ip>
            //     <act_name><![CDATA[新年红包]]></act_name>
            //     <remark><![CDATA[新年红包]]></remark>
            //     <nonce_str><![CDATA[50780e0cca98c8c8e814883e5caa672e]]></nonce_str>
            // </xml>
            SortedDictionary<string, string> sortedDictParams = new SortedDictionary<string, string>();
            sortedDictParams.Add("sign", sign);
            sortedDictParams.Add("mch_billno", mch_billno);
            sortedDictParams.Add("mch_id", mch_id);
            sortedDictParams.Add("wxappid", wxappid);
            sortedDictParams.Add("send_name", send_name);
            sortedDictParams.Add("re_openid", re_openid);
            sortedDictParams.Add("total_amount", total_amount.ToString());
            sortedDictParams.Add("total_num", total_num.ToString());
            sortedDictParams.Add("wishing", wishing);
            sortedDictParams.Add("client_ip", client_ip);
            sortedDictParams.Add("act_name", act_name);
            sortedDictParams.Add("remark", remark);
            sortedDictParams.Add("nonce_str", nonce_str);

            var postXmlData = WeiXinHelper.BuildPostXmlData(sortedDictParams);
            var url = string.Format("https://api.mch.weixin.qq.com/mmpaymkttransfers/sendredpack");
            var client = ToolFactory.Ioc.Get<IHttpClient>();
            X509Certificate x509Certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(certFilePath, certPwd);

            var result = client.Post(url, postXmlData, x509Certificate, new RemoteCertificateValidationCallback(CheckValidationResult));


            var sendRedPackResult = ToolFactory.CreateIXmlSerializeTool().DeserializeFromString<SendRedPackResult>(result);
            return sendRedPackResult;
        }
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;
            return false;
        }
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
        public Entities.SendRedPackResult SendRedPack(string certFilePath, string certPwd,
            string apiSecretKey, string mch_billno,
            string mch_id, string wxappid, string send_name, string re_openid, int total_amount,
            int total_num, string wishing, string client_ip, string act_name, string remark)
        {
            var nonce_str = WeiXinHelper.GetNonceStr();
            SortedDictionary<string, string> sortedDictParams = new SortedDictionary<string, string>();
            sortedDictParams.Add("nonce_str", nonce_str);
            sortedDictParams.Add("mch_billno", mch_billno);
            sortedDictParams.Add("mch_id", mch_id);
            sortedDictParams.Add("wxappid", wxappid);
            sortedDictParams.Add("send_name", send_name);
            sortedDictParams.Add("re_openid", re_openid);
            sortedDictParams.Add("total_amount", total_amount.ToString());
            sortedDictParams.Add("total_num", total_num.ToString());
            sortedDictParams.Add("wishing", wishing);
            sortedDictParams.Add("client_ip", client_ip);
            sortedDictParams.Add("act_name", act_name);
            sortedDictParams.Add("remark", remark);
            var sign = WeiXinPayHelper.GetSign(sortedDictParams, apiSecretKey);
            return SendRedPack(certFilePath, certPwd, nonce_str, sign, mch_billno, mch_id, wxappid, send_name, re_openid, total_amount, total_num, wishing, client_ip, act_name, remark);
        }
    }
}
