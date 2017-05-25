
using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Zh.Framework.Helpers
{
    public class GZipHelper
    {
        /// <summary>
        /// 解压gzip文件
        /// </summary>
        /// <param name="gzipFile">待解压gzip文件</param>
        /// <param name="unGZipFilePath">待解压文件路径</param>
        public static void UnGZip(string gzipFile, string unGZipFilePath)
        {
            using (var fs = File.OpenRead(gzipFile))
            {
                using (var zg = new GZipStream(fs, System.IO.Compression.CompressionMode.Decompress))
                {
                    using (var outfs = File.OpenWrite(unGZipFilePath))
                    {
                        byte[] bytes = new byte[4096];
                        int n;
                        while ((n = zg.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            outfs.Write(bytes, 0, n);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 解压到StreamReader流中,以encoding编码格式
        /// </summary>
        /// <param name="gzipFile">待解压gzip文件</param>
        /// <param name="encoding">待解压encoding编码格式</param>
        /// <returns></returns>

        public static StreamReader UnGZipToStreamReader(string gzipFile, Encoding encoding)
        {
            var fs = File.OpenRead(gzipFile);

            var zg = new GZipStream(fs, System.IO.Compression.CompressionMode.Decompress);

            StreamReader sr = new StreamReader(zg, encoding);

            return sr;

        }
        /// <summary>
        /// 解压到StreamReader流中,以Encoding.UTF8编码格式
        /// </summary>
        /// <param name="gzipFile">待解压gzip文件</param> 
        /// <returns></returns>

        public static StreamReader UnGZipToStreamReader(string gzipFile)
        {
            return UnGZipToStreamReader(gzipFile, Encoding.UTF8);
        }
    }
}
