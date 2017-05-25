using Zh.Framework.Tools.FileTool;
using System;
using System.IO;
using Zh.Framework.Tools.DirectoryTool;
using Zh.Framework.Tools.DirectoryTool.Imp;
using System.Reflection;

namespace Zh.Framework.Tools.FileTool
{

    public class FileToolImpTest
    {


        public static bool CombinePath()
        {

            IFileTool target = ToolFactory.Ioc.Get<IFileTool>();

            string expected = string.Format("1{0}2{0}c", Path.DirectorySeparatorChar);
            string actual = target.CombinePath("1", "2", "c");
            return expected == actual;
        }
    }
}
