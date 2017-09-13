using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Zh.Framework.Tools.FileTool;

namespace Zh.Framework.Tools.SerializeTool.Imp
{
    public class XmlSerializeToolImp : IXmlSerializeTool
    {
        public T DeserializeFromFile<T>(string pFileFullName)
        {
            return (T)DeserializeFromFile(typeof(T), pFileFullName);
        }

        public T DeserializeFromString<T>(string pXml)
        {
            return (T)DeserializeFromString(typeof(T), pXml);
        }



        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="pType">对象类型</param>
        /// <param name="pXml">文件路径</param>
        /// <returns></returns>
        public object DeserializeFromFile(Type pType, string pFileFullName)
        {

            FileInfo fileInfo = new FileInfo(pFileFullName);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }
            if (!fileInfo.Exists)
            {
                var content = SerializeToString(pType.Assembly.CreateInstance(pType.FullName));
                File.WriteAllText(pFileFullName, content);
            }
            var tContent = File.ReadAllText(pFileFullName);
            var result = DeserializeFromString(pType, tContent);
            return result;

        }


        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="pObj">对象</param>
        /// <param name="pFileName">文件路径</param>
        public void SerializeToFile(object pObj, string pFileName)
        {
            var content = SerializeToString(pObj);

            File.WriteAllText(pFileName, content, System.Text.Encoding.UTF8);
        }

        /// <summary>
        /// xml序列化成字符串
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>xml字符串</returns>
        public string SerializeToString(object pObj)
        {
            string returnStr = "";
            XmlSerializer serializer = new XmlSerializer(pObj.GetType());
            MemoryStream ms = new MemoryStream();
            XmlTextWriter xtw = null;
            StreamReader sr = null;
            try
            {
                xtw = new System.Xml.XmlTextWriter(ms, Encoding.UTF8);
                xtw.Formatting = System.Xml.Formatting.Indented;
                serializer.Serialize(xtw, pObj);
                ms.Seek(0, SeekOrigin.Begin);
                sr = new StreamReader(ms);
                returnStr = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
                if (sr != null)
                    sr.Close();
                ms.Close();
            }
            return returnStr;

        }
        /// <summary>
        /// 反序列化对象成字符串
        /// </summary>
        /// <param name="pType">反序列化对象类型</param>
        /// <param name="pXml">反序列化字符串</param>
        /// <returns></returns>
        public object DeserializeFromString(Type pType, string pXml)
        {
            byte[] b = System.Text.Encoding.UTF8.GetBytes(pXml);
            XmlSerializer serializer = new XmlSerializer(pType);
            return serializer.Deserialize(new MemoryStream(b));
        }

        public object DeserializeFromString(string content, Type type)
        {
            return DeserializeFromString(type, content);
        }
    }
}
