using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Zh.Framework.Tools.ValidatorTool;

namespace Zh.Framework.Tools.FileTool
{
    public class FileToolImp : IFileTool
    {
 
        IValidatorTool _ValidatorHelper = null;
        IValidatorTool ValidatorHelper
        {
            get
            {
                if (_ValidatorHelper == null)
                {
                    _ValidatorHelper = ToolFactory.CreateIValidatorTool();
                }
                return _ValidatorHelper;
            }
        }
 

        public string CombinePath(params string[] pPaths)
        {
            var basePath = "";
            foreach (var path in pPaths)
            {
                if (ValidatorHelper.IsEmpty(path))
                {
                    continue;
                }

                basePath = Path.Combine(basePath, path);
            }
            return basePath;
        }

        public string ReadFromFile(string fileFullName)
        {
            IsExistOrCreate(fileFullName);

            return ReadFromFile(fileFullName, System.Text.Encoding.UTF8);
        }
        public string ReadFromFile(string fileFullName, Encoding encoding)
        {

            return File.ReadAllText(fileFullName, encoding);
        }
        public void WriteToFile(string fileFullName, string content)
        {

            WriteToFile(fileFullName, content, System.Text.Encoding.UTF8);
        }

        public void WriteToFile(string fileFullName, string content, Encoding encoding)
        {
            IsExistOrCreate(fileFullName);

            File.WriteAllText(fileFullName, content, encoding);
        }

        public void IsExistOrCreate(string fileFullName)
        {
            FileInfo fileInfo = new FileInfo(fileFullName);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
        }
    }
}
