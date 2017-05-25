using System;
using Zh.WeiXin.BLL.API.JSSDK.Entities;
using Zh.Framework.Entities;
namespace Zh.WeiXin.BLL.API
{
    /// <summary>
    /// 微信JSSDK API
    /// </summary>
    public interface IJSAPI
    {
        string GetNonce();
        long GetTimestamp();
        string GetSignature(string jsapi_ticket, string noncestr, long timestamp, string url, out string string1);
        GenericExecResult<string> GetJsTickect(string accessToken);
        GenericExecResult<JSSDKConfig> CreateJSSDKConfig(string accessToken, string url);
    }
}
