using System;
using System.Collections.Generic;

using System.Text;
using Zh.WeiXin.BLL.API.Entities;
using Zh.WeiXin.BLL.Caches;

namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信基础数据API
    /// </summary>
    public interface IBasicAPI
    {
        /// <summary>
        /// GetAccessToken方法缓存,默认实现类Zh.WeiXin.BLL.Caches.Imp.FileGetAccessTokeCache
        /// </summary>
          IGetAccessTokenCache IGetAccessTokenCache { get; set; }
        /// <summary>
        /// 调用接口凭证AccessToken过期时间,单位秒
        /// </summary>
          int AccessTokenExpireSeconds { get; }
        /// <summary>
        /// 获取调用接口凭证AccessToken
        /// </summary>
        /// <param name="appId">微信AppId</param>
        /// <param name="appSecrect">微信AppSecrect</param>
        /// <returns>AccessToken</returns>
        GetAccessTokenResult GetAccessToken(string appId, string appSecrect);
    }
}
