using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ConfigTool
{
    public interface IXmlConfigTool
    {
        T DeserializeFromFile<T>(string pFileFullName);

        T DeserializeFromString<T>(string pXml);
    }
}
