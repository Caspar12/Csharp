using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Zh.Framework.Tools.FileTool;

namespace Zh.Framework.Tools.SerializeTool.Imp
{
    public class JsonSerializeTool : IJsonSerializeTool
    {

        public T DeserializeFromFile<T>(string pFileFullName)
        {
            var content = File.ReadAllText(pFileFullName);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
        }

        public object DeserializeFromString(string content, Type type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(content, type);
        }

        public T DeserializeFromString<T>(string content)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
        }

        public void SerializeToFile(object pObj, string pFileFullName)
        {
            var content = SerializeToString(pObj);
            File.WriteAllText(pFileFullName, content);
        }

        public string SerializeToString(object pObj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(pObj);
        }
    }
}
