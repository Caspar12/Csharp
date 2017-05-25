using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Cache;
using Zh.WeiXin.BLL.API.Entities;

namespace Zh.WeiXin.BLL.Caches.Imp
{
    /// <summary>
    /// 默认IBasicAPI类GetAccessToken方法缓存实现类
    /// </summary>
    public class DefaultGetAccessTokeCache : IGetAccessTokenCache
    {
        /// <summary>
        /// 可注入实现Zh.Framework.Cache.ICache接口类型
        /// </summary>
        public ICache ICache { get; set; }
        public API.Entities.GetAccessTokenResult Get(string appId)
        {
            return ICache.Get<GetAccessTokenResult>(appId);
        }

        public void Set(string key, API.Entities.GetAccessTokenResult getAccessTokenResult)
        {
            ICache.Set(key, getAccessTokenResult, DateTime.Now.AddSeconds(7200));
        }
    }
}
