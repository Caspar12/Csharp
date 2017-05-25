using System;
using System.Collections.Generic;

using System.Text;
using System.Net;
using Zh.Net.Http;
using Zh.Framework.Tools;
using Zh.Framework.Tools.CryptogramTool;
using Zh.Framework.Cache;
using Zh.WeiXin.BLL.API.JSSDK;
using Zh.WeiXin.BLL.API.JSSDK.Entities;
using Zh.WeiXin.BLL.Helpers;
using Zh.WeiXin.BLL.API.Entities;
using Zh.Framework.Entities;
using Zh.Framework.Helpers;
namespace Zh.WeiXin.BLL.API.Imp
{
    /// <summary>
    /// http://mp.weixin.qq.com/wiki/7/aaa137b55fb2e0456bf8dd9148dd613f.html
    /// 微信JS-SDK使用权限签名算法
    /// </summary>
    public class JSAPI : IJSAPI
    {
        private ICache _ICache { get; set; }
        string _CacheJsTickectId = "CACHE_JSTICKECT";
        /// <summary>
        ///  JsTickect缓存标识
        /// </summary>
        public string CacheJsTickectId
        {
            get
            {
                return _CacheJsTickectId;
            }
            set
            {
                _CacheJsTickectId = value;
            }
        }

        int _CacheJsTickectExpireTimeoutSecond = 7200;
        /// <summary>
        /// JsTickect缓存失效时间7200秒
        /// </summary>
        public int CacheJsTickectExpireTimeoutSecond
        {
            get
            {
                return _CacheJsTickectExpireTimeoutSecond;
            }
            set
            {
                _CacheJsTickectExpireTimeoutSecond = value;
            }
        }
        /// <summary>
        /// 获取jsapi_ticket
        /// jsapi_ticket是公众号用于调用微信JS接口的临时票据。
        /// 正常情况下，jsapi_ticket的有效期为7200秒，通过access_token来获取。
        /// 由于获取jsapi_ticket的api调用次数非常有限，频繁刷新jsapi_ticket会导致api调用受限，影响自身业务，开发者必须在自己的服务全局缓存jsapi_ticket 。
        /// </summary>
        /// <param name="accessToken">微信全局access_token</param>
        /// <returns></returns>
        public GenericExecResult<string> GetJsTickect(string accessToken)
        {
            var cacheJsTickect = _ICache.Get<string>(CacheJsTickectId);
            if (ToolFactory.CreateIValidatorTool().IsNotEmpty(cacheJsTickect))
            {
                return new GenericExecResult<string>()
                {
                    Success = true,
                    Data = cacheJsTickect
                };
            };
            var url = string.Format("https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token={0}&type=jsapi", accessToken);
            var downloadResult = WeiXinHelper.DownloadToString(url);

            if (WeiXinHelper.IsFailureInvokeWeiXinAPI(downloadResult))
            {
                return WeiXinHelper.FromDownloadResultToErrorGenericExecResult(downloadResult);
            }
            var jsTicket = WeiXinHelper.ToGetJsTickectResultDto(downloadResult.Data).ticket;
            _ICache.Set(CacheJsTickectId, jsTicket, DateTime.Now.AddSeconds(CacheJsTickectExpireTimeoutSecond));
            return new GenericExecResult<string>()
            {
                Success = true,
                Data = jsTicket
            };
        }


        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="jsapi_ticket">jsapi_ticket</param>
        /// <param name="noncestr">随机字符串(必须与wx.config中的nonceStr相同)</param>
        /// <param name="timestamp">时间戳(必须与wx.config中的timestamp相同)</param>
        /// <param name="url">当前网页的URL，不包含#及其后面部分(必须是调用JS接口页面的完整URL)</param>
        /// <returns></returns>
        public string GetSignature(string jsapi_ticket, string noncestr, long timestamp, string url, out string string1)
        {
            var string1Builder = new StringBuilder();
            string1Builder.Append("jsapi_ticket=").Append(jsapi_ticket).Append("&")
                          .Append("noncestr=").Append(noncestr).Append("&")
                          .Append("timestamp=").Append(timestamp).Append("&")
                          .Append("url=").Append(url.IndexOf("#") >= 0 ? url.Substring(0, url.IndexOf("#")) : url);
            string1 = string1Builder.ToString();
            return ToolFactory.Ioc.Get<ICryptogramTool>().SHA1(string1);
        }


        /// <summary>
        /// 创建随机字符串  
        /// </summary>
        /// <returns></returns>
        public string GetNonce()
        {
            return WeiXinHelper.GetNonceStr();
        }
        /// <summary>
        /// 创建时间戳        
        /// </summary>
        /// <returns></returns>
        public long GetTimestamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }
        /// <summary>
        /// 生成JS-SDK相关配置
        /// </summary>
        /// <param name="accessToken">微信全局access_token</param>
        /// <returns></returns>
        public GenericExecResult<JSSDKConfig> CreateJSSDKConfig(string accessToken, string url)
        {
            var jsTickectResult = GetJsTickect(accessToken);
            if (jsTickectResult.IsFailure)
            {
                return EntitiesHelper.ConvertGenericExecResult<JSSDKConfig, string>(jsTickectResult);
            }
            var jsTickect = jsTickectResult.Data;
            var nonce = GetNonce();
            var timestamp = GetTimestamp();
            var string1 = string.Empty;
            var signature = GetSignature(jsTickect, nonce, timestamp, url, out string1);
            return new GenericExecResult<JSSDKConfig>()
            {
                Success = true,
                Data = new JSSDKConfig()
                {
                    JsTickect = jsTickect,
                    Nonce = nonce,
                    Signature = signature,
                    Timestamp = timestamp
                }
            };
        }
    }
}
