using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Zh.Framework.Tools.DirectoryTool.Imp
{
    public class DirectoryToolImp : IDirectoryTool
    {
        public void Copy(string pSrcDir, string pTargetDir)
        {
            DirectoryInfo source = new DirectoryInfo(pSrcDir);
            DirectoryInfo targetDirInfo = new DirectoryInfo(pTargetDir);

            if (targetDirInfo.FullName.StartsWith(source.FullName, StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exception("父目录不能拷贝到子目录！");
            }

            if (!source.Exists)
            {
                return;
            }

            if (!targetDirInfo.Exists)
            {
                targetDirInfo.Create();
            }

            FileInfo[] files = source.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                File.Copy(files[i].FullName, targetDirInfo.FullName + Path.DirectorySeparatorChar + files[i].Name, true);
            }

            DirectoryInfo[] dirs = source.GetDirectories();

            for (int j = 0; j < dirs.Length; j++)
            {
                Copy(dirs[j].FullName, targetDirInfo.FullName + Path.DirectorySeparatorChar + dirs[j].Name);
            }
        }
    }
}
