using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Zh.Framework.Tools.ConfigTool.Imp
{
    public class XmlConfigToolImp : IXmlConfigTool
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
        public static object DeserializeFromFile(Type pType, string pFileFullName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(pFileFullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlSerializer serializer = new XmlSerializer(pType);
                return serializer.Deserialize(fs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }


        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="pObj">对象</param>
        /// <param name="pFileName">文件路径</param>
        public static void SerializeToFile(object pObj, string pFileName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(pFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                XmlSerializer serializer = new XmlSerializer(pObj.GetType());
                serializer.Serialize(fs, pObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

        }

        /// <summary>
        /// xml序列化成字符串
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>xml字符串</returns>
        public static string Serialize(object pObj)
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
        public static object DeserializeFromString(Type pType, string pXml)
        {
            byte[] b = System.Text.Encoding.UTF8.GetBytes(pXml);
            XmlSerializer serializer = new XmlSerializer(pType);
            return serializer.Deserialize(new MemoryStream(b));
        }


    }
}
