using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;  
using System.Net.Security;

namespace Zh.Net.Http.Impls
{
    public class HttpClient : IHttpClient
    {
        public string DownloadToString(string url)
        {
            return this.Get(url);
        }

        public string Post(string url, string data)
        {

            HttpWebRequest requestScore = (HttpWebRequest)WebRequest.Create(url);
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] dataBytes = encoding.GetBytes(data);
            requestScore.Method = "Post";
            requestScore.ContentType = "application/x-www-form-urlencoded";
            requestScore.ContentLength = dataBytes.Length;
            requestScore.KeepAlive = true;

            Stream stream = requestScore.GetRequestStream();
            stream.Write(dataBytes, 0, dataBytes.Length);
            stream.Close();

            HttpWebResponse responseSorce = (HttpWebResponse)requestScore.GetResponse();
            StreamReader reader = new StreamReader(responseSorce.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();

            requestScore = null;
            responseSorce.Close();
            responseSorce = null;
            reader = null;
            stream = null;

            return content;

        }

        public string Get(string url)
        {

            HttpWebRequest requestScore = (HttpWebRequest)WebRequest.Create(url);

            UTF8Encoding encoding = new UTF8Encoding();

            requestScore.Method = "Get";
            requestScore.ContentType = "application/x-www-form-urlencoded";
            requestScore.KeepAlive = true;

            HttpWebResponse responseSorce = (HttpWebResponse)requestScore.GetResponse();
            StreamReader reader = new StreamReader(responseSorce.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();

            requestScore = null;
            responseSorce.Close();
            responseSorce = null;
            reader = null;

            return content;

        }


        public string Post(string url, string data, System.Security.Cryptography.X509Certificates.X509Certificate x509Certificate, System.Net.Security.RemoteCertificateValidationCallback remoteCertificateValidationCallback)
        {
            HttpWebRequest requestScore = (HttpWebRequest)WebRequest.Create(url);
            if (x509Certificate != null)
            {
                requestScore.ClientCertificates.Add(x509Certificate);
            }
            if (remoteCertificateValidationCallback != null)
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(remoteCertificateValidationCallback);
            }
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] dataBytes = encoding.GetBytes(data);
            requestScore.Method = "Post";
            requestScore.ContentType = "application/x-www-form-urlencoded";
            requestScore.ContentLength = dataBytes.Length;
            requestScore.KeepAlive = true;

            Stream stream = requestScore.GetRequestStream();
            stream.Write(dataBytes, 0, dataBytes.Length);
            stream.Close();

            HttpWebResponse responseSorce = (HttpWebResponse)requestScore.GetResponse();
            StreamReader reader = new StreamReader(responseSorce.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();

            requestScore = null;
            responseSorce.Close();
            responseSorce = null;
            reader = null;
            stream = null;

            return content;
        }
    }
}
