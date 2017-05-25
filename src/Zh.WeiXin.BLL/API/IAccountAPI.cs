using System;
using System.Collections.Generic;
using System.Text;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信用户基本信息API
    /// </summary>
    public interface IAccountAPI
    {
        /// <summary>
        /// 获取微信用户基本信息
        /// </summary>
        /// <param name="accessToken">Zh.WeiXin.BLL.API.IBasicAPI.GetAccessToken方法返回的调用接口凭证</param>
        /// <param name="openId">普通用户的标识，对当前公众号唯一</param>
        /// <param name="lang">返回国家地区语言版本，zh_CN 简体，zh_TW 繁体，en 英语</param>
        /// <returns>微信用户基本信息</returns>
        WeiXinAccount GetBasicAccountInfo(string accessToken, string openId, string lang = "zh_CN");
        /// <summary>
        /// 获取多个微信用户基本信息,一次最多100
        /// </summary>
        /// <param name="accessToken">Zh.WeiXin.BLL.API.IBasicAPI.GetAccessToken方法返回的调用接口凭证</param>
        /// <param name="getBasicAccountInfosParams">拉取数据参数数据结构</param>
        /// <returns>多个微信用户基本信息</returns>
        IList<WeiXinAccount> GetBasicAccountInfos(string accessToken, IList<GetBasicAccountInfosParam> getBasicAccountInfosParams);
    }
}
