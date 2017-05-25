using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools;

namespace Zh.WeiXin.BLL.Helpers
{
    public static class WeiXinPayHelper
    {
        /// <summary>
        /// 生成签名
        /// 签名在线验证工具：
        /// http://mch.weixin.qq.com/wiki/tools/signverify/
        /// </summary>
        /// <param name="stringADict">参与签名生成的参数列表</param>
        /// <param name="apiSecretKey">商家私钥</param>
        /// <returns></returns>
        public static string GetSign(IDictionary<string, string> stringADict, string apiSecretKey)
        {
            var sb = new StringBuilder();
            var sortedDict = new SortedDictionary<string, string>(stringADict);//参数名ASCII码从小到大排序（字典序）；
            foreach (var item in sortedDict)
            {
                if (string.IsNullOrEmpty(item.Value)) continue;//参数的值为空不参与签名；
                if (string.Compare(item.Key, "sign", true) == 0) continue;    // 参数中为签名的项，不参加计算
                sb.Append(item.Key).Append("=").Append(item.Value).Append("&");
            }
            var string1 = sb.ToString();
            string1 = string1.Remove(string1.Length - 1, 1);
            sb.Append("key=").Append(apiSecretKey);//在stringA最后拼接上key=(API密钥的值)得到stringSignTemp字符串
            var stringSignTemp = sb.ToString();
            var sign = ToolFactory.CreateICryptogramTool().MD5(stringSignTemp, "UTF-8").ToUpper();//对stringSignTemp进行MD5运算，再将得到的字符串所有字符转换为大写，得到sign值signValue。 
            return sign;
        }
    }
}
