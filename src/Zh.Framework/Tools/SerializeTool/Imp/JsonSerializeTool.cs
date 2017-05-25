using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Zh.Framework.Tools.FileTool;

namespace Zh.Framework.Tools.SerializeTool.Imp
{
    public class JsonSerializeTool : IJsonSerializeTool
    {
        IFileTool _FileHelper = null;
        IFileTool FileHelper
        {
            get
            {
                if (_FileHelper == null)
                {
                    _FileHelper = new FileToolImp();
                }
                return _FileHelper;
            }
        }
        public T DeserializeFromFile<T>(string pFileFullName)
        {
            var content = FileHelper.ReadFromFile(pFileFullName);
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
            FileHelper.WriteToFile(pFileFullName, content);
        }

        public string SerializeToString(object pObj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(pObj);
        }
    }
}
