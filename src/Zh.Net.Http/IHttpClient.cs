using System;
using System.Collections.Generic;
using System.Text; 
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Zh.Net.Http
{
    public interface IHttpClient
    {
        /// <summary>
        /// Get方法下载内容,转为字符串
        /// </summary>
        /// <param name="url">下载Url</param>
        /// <returns></returns>
        string DownloadToString(string url);
        /// <summary>
        /// Post 字符串data到url,并返回字符串内容
        /// </summary>
        /// <param name="url">post url</param>
        /// <param name="data">post data</param>
        /// <returns></returns>
        string Post(string url, string data);
        /// <summary>
        /// Get url,并返回字符串内容
        /// </summary>
        /// <param name="url">get url</param>
        /// <returns></returns>
        string Get(string url);
        /// <summary>
        /// Post 字符串data到url,并返回字符串内容
        /// </summary>
        /// <param name="url">post url</param>
        /// <param name="data">post data</param>
        /// <param name="x509Certificate">x509Certificate</param>
        /// <param name="remoteCertificateValidationCallback">RemoteCertificateValidationCallback</param>
        /// <returns></returns>
        string Post(string url, string data, X509Certificate x509Certificate, RemoteCertificateValidationCallback remoteCertificateValidationCallback);
    }
}
