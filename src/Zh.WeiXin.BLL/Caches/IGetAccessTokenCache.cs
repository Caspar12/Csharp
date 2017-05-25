using System;
using System.Collections.Generic;
using System.Text;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.WeiXin.BLL.Caches
{
    /// <summary>
    /// IBasicAPI类GetAccessToken方法缓存类
    /// </summary>
    public interface IGetAccessTokenCache
    {
        GetAccessTokenResult Get(string appId);
        void Set(string key, GetAccessTokenResult getAccessTokenResult);
    }
}
