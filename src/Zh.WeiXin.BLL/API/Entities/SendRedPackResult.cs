using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// 营销工具现金红包发送结果数据结构
    /// </summary>
    [XmlRootAttribute(Namespace = "", ElementName = "xml")]
    public class SendRedPackResult
    {
        /// <summary>
        /// 返回状态码 必填 SUCCESS/FAIL 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
        /// </summary>
        public string return_code { get; set; }
        /// <summary>
        /// 返回信息 非必填 返回信息，如非空，为错误原因;如：签名失败、参数格式校验错误
        /// </summary>
        public string return_msg { get; set; }
        #region 以下字段在return_code为SUCCESS的时候有返回

        /// <summary>
        /// 签名 必填 详见签名生成算法,https://pay.weixin.qq.com/wiki/doc/api/tools/cash_coupon.php?chapter=4_3
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 业务结果 必填 SUCCESS/FAIL
        /// </summary>
        public string result_code { get; set; }
        /// <summary>
        /// 错误代码 非必填
        /// </summary>
        public string err_code { get; set; }
        /// <summary>
        /// 错误代码描述 非必填
        /// </summary>
        public string err_code_des { get; set; }

        #endregion

        #region 以下字段在return_code和result_code都为SUCCESS的时候有返
        /// <summary>
        /// 商户订单号 
        /// </summary>
        public string mch_billno { get; set; }
        /// <summary>
        /// 商户号
        /// </summary>
        public string mch_id { get; set; }
        /// <summary>
        /// 公众账号appid
        /// </summary>
        public string wxappid { get; set; }
        /// <summary>
        /// 用户openid 接受收红包的用户用户在wxappid下的openid
        /// </summary>
        public string re_openid { get; set; }
        /// <summary>
        /// 付款金额，单位分
        /// </summary>
        public string total_amount { get; set; }
        /// <summary>
        /// 发放成功时间
        /// </summary>
        public string send_time { get; set; }
        /// <summary>
        /// 微信单号 红包订单的微信单号
        /// </summary>
        public string send_listid { get; set; }
        #endregion
        /// <summary>
        /// 是否通讯成功
        /// </summary>
        public bool IsSuccessReturnCode
        {
            get
            {
                return this.return_code.Equals("SUCCESS", StringComparison.OrdinalIgnoreCase);
            }
        }
        /// <summary>
        /// 是否通讯失败
        /// </summary>
        public bool IsFailureReturnCode
        {
            get
            {
                return !this.IsSuccessReturnCode;
            }
        }
        /// <summary>
        /// 是否业务成功
        /// </summary>
        public bool IsSuccessResultCode
        {
            get
            {
                return this.result_code.Equals("SUCCESS", StringComparison.OrdinalIgnoreCase);
            }
        }
        /// <summary>
        /// 是否业务失败
        /// </summary>
        public bool IsFailureResultCode
        {
            get
            {
                return !this.IsSuccessResultCode;
            }
        }
        /// <summary>
        /// 是否通讯与业务都成功
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return this.IsSuccessReturnCode && this.IsSuccessResultCode;
            }
        }
        /// <summary>
        /// 是否通讯或业务失败
        /// </summary>
        public bool IsFailure
        {
            get
            {
                return this.IsFailureResultCode || this.IsFailureReturnCode;
            }
        }
    }
}
