using System;
using System.Collections.Generic;
using System.Text;
using Zh.WeiXin.BLL.API.Entities;
using Zh.Framework.Tools;
using Zh.Net.Http;
using Zh.WeiXin.BLL.Helpers;

namespace Zh.WeiXin.BLL.API.Imp
{
    public class AccountAPI : IAccountAPI
    {
        /// <summary>
        /// 获取微信基本用户信息Url - https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang={2}
        /// </summary>
        public static string WEIXIN_GET_BASIC_ACCOUNT_INFO_URL = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang={2}";
        public WeiXinAccount GetBasicAccountInfo(string accessToken, string openId, string lang = "zh_CN")
        {
            var url = string.Format(WEIXIN_GET_BASIC_ACCOUNT_INFO_URL, accessToken, openId, lang);
            var client = ToolFactory.Ioc.Get<IHttpClient>();
            var result = client.Get(url);
            WeiXinHelper.IsFailureInvokeWeiXinAPIThrowException(result);
            var modelResult = WeiXinHelper.JsonHelper().DeserializeFromString<WeiXinAccount>(result);
            return modelResult;
        }


        public IList<WeiXinAccount> GetBasicAccountInfos(string accessToken, IList<GetBasicAccountInfosParam> getBasicAccountInfosParams)
        {
            var user_list = new GetBasicAccountInfosParamUserList()
            {
                user_list = getBasicAccountInfosParams
            };
            var url = string.Format("https://api.weixin.qq.com/cgi-bin/user/info/batchget?access_token={0}", accessToken);
            var client = ToolFactory.Ioc.Get<IHttpClient>();
            var postData = ToolFactory.CreateIJsonSerializeTool().SerializeToString(user_list);
            var result = client.Post(url, postData);
            WeiXinHelper.IsFailureInvokeWeiXinAPIThrowException(result);
            var modelResult = WeiXinHelper.JsonHelper().DeserializeFromString<GetBasicAccountInfosResultUserInfoList>(result);
            return modelResult.user_info_list;
        }
    }
}
