using System;
using System.Collections.Generic;

using System.Text;
using Zh.Framework.Tools;
using Zh.Net.Http;
using Zh.Framework.Entities;
using Zh.WeiXin.BLL.API.Entities;
using Zh.Framework.Exceptions;
using Zh.Framework.Tools.SerializeTool;

namespace Zh.WeiXin.BLL.Helpers
{
    public class WeiXinHelper
    {
        public static GenericExecResult<string> DownloadToString(string url)
        {
            var client = ToolFactory.Ioc.Get<IHttpClient>();

            var downLoadResult = client.DownloadToString(url);

            return new GenericExecResult<string>()
            {
                Data = downLoadResult
            };
        }

        public static bool IsSuccessInvokeWeiXinAPI(string returnResult)
        {
            if (returnResult.IndexOf("{\"errcode\":") != -1)
            {
                var errorInfo = ToErrorResultDto(returnResult);
                return errorInfo.errcode == "0";
            }
            else
            {
                return true;
            }
        }
        public static bool IsFailureInvokeWeiXinAPI(string returnResult)
        {
            return !IsSuccessInvokeWeiXinAPI(returnResult);
        }
        public static void IsFailureInvokeWeiXinAPIThrowException(string returnResult)
        {
            if (!IsSuccessInvokeWeiXinAPI(returnResult))
            {
                var errorResult = ToErrorResultDto(returnResult);
                throw new BaseException(string.Format("{0},代码:{1}", errorResult.errmsg, errorResult.errcode));
            }
        }
        public static bool IsFailureInvokeWeiXinAPI(GenericExecResult<string> downloadResult)
        {
            return IsFailureInvokeWeiXinAPI(downloadResult.Data);
        }
        public static ErrorResultDto ToErrorResultDto(string returnResult)
        {
            var iSerialize = ToolFactory.CreateIJsonSerializeTool();
            return iSerialize.DeserializeFromString<ErrorResultDto>(returnResult);
        }
        public static GenericExecResult<string> FromDownloadResultToErrorGenericExecResult(GenericExecResult<string> downloadResult)
        {
            var err = ToErrorResultDto(downloadResult.Data);
            var gerr = FromErrorResultToGenericExecResult(err);
            return gerr;
        }
        public static GenericExecResult<string> FromErrorResultToGenericExecResult(ErrorResultDto errorResult)
        {
            return new GenericExecResult<string>()
            {
                Message = string.Format("{0},代码:{1}", errorResult.errmsg, errorResult.errcode),
                Success = false
            };
        }
        public static GetJsTickectResultDto ToGetJsTickectResultDto(string content)
        {
            var iSerialize = ToolFactory.CreateIJsonSerializeTool();
            return iSerialize.DeserializeFromString<GetJsTickectResultDto>(content);
        }

        public static ISerializeTool JsonHelper()
        {
            return ToolFactory.CreateIJsonSerializeTool();
        }

        /// <summary>
        /// 生成POST的xml数据字符串
        /// </summary>
        /// <param name="postdataDict">>参与生成的参数列表</param> 
        /// <returns></returns>
        public static string BuildPostXmlData(IDictionary<string, string> postdataDict, bool isAddXmlTag = true)
        {
            var sb2 = new StringBuilder();
            if (isAddXmlTag) sb2.Append("<xml>");
            foreach (var sA in postdataDict)
            {
                sb2.Append("<" + sA.Key + ">");
                //if (sA.Key.Equals("act_name", StringComparison.OrdinalIgnoreCase))
                //{
                //    sb2.AppendFormat("{0}", sA.Value);
                //}
                //else
                //{
                //    sb2.AppendFormat("<![CDATA[{0}]]>", sA.Value);
                //}
                sb2.AppendFormat("<![CDATA[{0}]]>", sA.Value);
                sb2.Append("</" + sA.Key + ">");
            }
            if (isAddXmlTag) sb2.Append("</xml>");
            return sb2.ToString();
        }
        private static string[] strs = new string[]
        {
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
        };
        /// <summary>
        /// 创建随机字符串  
        /// </summary>
        /// <returns></returns>
        public static string GetNonceStr()
        {
            Random r = new Random();
            var sb = new StringBuilder();
            var length = strs.Length;
            for (int i = 0; i < 15; i++)
            {
                sb.Append(strs[r.Next(length - 1)]);
            }
            return sb.ToString();
        }
    }
}
