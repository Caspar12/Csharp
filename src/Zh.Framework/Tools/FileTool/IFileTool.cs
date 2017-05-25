using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.FileTool
{
    public interface IFileTool
    {
        string CombinePath(params string[] pPaths);

        string ReadFromFile(string fileFullName);
        string ReadFromFile(string fileFullName, Encoding encoding);
        void WriteToFile(string fileFullName, string content);
        void WriteToFile(string fileFullName, string content, Encoding encoding);

        void IsExistOrCreate(string fileFullName);
    }
}
