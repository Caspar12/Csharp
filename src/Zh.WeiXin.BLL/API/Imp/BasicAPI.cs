using System;
using System.Collections.Generic;

using System.Text;
using Zh.Framework.Cache;
using Zh.Framework.Tools;
using Zh.Net.Http;
using Zh.WeiXin.BLL.API.Events;
using Zh.WeiXin.BLL.Helpers;
using Zh.WeiXin.BLL.API.Entities;
using Zh.WeiXin.BLL.Caches;

namespace Zh.WeiXin.BLL.API.Imp
{
    public class BasicAPI : IBasicAPI
    {

        /// <summary>
        /// GetAccessToken方法缓存,默认实现类Zh.WeiXin.BLL.Caches.Imp.FileGetAccessTokeCache
        /// </summary>
        public IGetAccessTokenCache IGetAccessTokenCache { get; set; }


        public GetAccessTokenResult GetAccessToken(string appId, string appSecret)
        {
            var cacheKey = appId;

            if (IGetAccessTokenCache != null)
            {
                var cacheObj = IGetAccessTokenCache.Get(cacheKey);
                if (ToolFactory.CreateIValidatorTool().IsNotEmpty(cacheObj)) return cacheObj;
            }
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", appId, appSecret);
            var client = ToolFactory.Ioc.Get<IHttpClient>();
            var result = client.DownloadToString(url);
            if (WeiXinHelper.IsFailureInvokeWeiXinAPI(result))
            {
                throw new Exception(result);
            }
            var iJson = ToolFactory.CreateIJsonSerializeTool();
            var accessToken = iJson.DeserializeFromString<GetAccessTokenResult>(result);
            if (IGetAccessTokenCache != null)
            {
                IGetAccessTokenCache.Set(cacheKey, accessToken);
            }
            return accessToken;
        }


        public int AccessTokenExpireSeconds
        {
            get
            {
                return 7200;
            }
        }
    }
}
