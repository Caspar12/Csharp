using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Helpers
{
    public class UrlHelper
    {
        public static string Concat(params string[] urls)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var url in urls)
            {
                if (string.IsNullOrEmpty(url)) continue;
                var urlTemp = string.Empty;
                if (sb.Length > 0 && sb[sb.Length - 1] != '/')
                {
                    sb.Append("/");
                }
                if (url[0] == '/')
                {
                    urlTemp = url.Remove(0, 1);
                }
                else
                {
                    urlTemp = url;
                }
                sb.Append(urlTemp);
            }
            return sb.ToString();
        }
    }
}
