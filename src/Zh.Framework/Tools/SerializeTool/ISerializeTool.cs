using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.SerializeTool
{
    public interface ISerializeTool
    {
        T DeserializeFromFile<T>(string pFileFullName);

        T DeserializeFromString<T>(string content);

        object DeserializeFromString(string content, Type type);

        void SerializeToFile(object pObj, string pFileFullName);

        string SerializeToString(object pObj);
    }
}
