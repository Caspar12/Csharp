using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.WeiXin.BLL.API.Entities
{
    /// <summary>
    /// GetBasicAccountInfos方法的参数数据结构
    /// </summary>
    public class GetBasicAccountInfosParam
    {
        /// <summary>
        /// 必选,用户的标识，对当前公众号唯一
        /// </summary>
        public string openid { get; set; }
        string _lang = "zh_CN";
        /// <summary>
        /// 可选,国家地区语言版本，zh_CN 简体，zh_TW 繁体，en 英语，默认为zh-CN
        /// </summary>
        public string lang { get { return _lang; } set { _lang = value; } }
    }
}
