using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.DirectoryTool
{
    public interface IDirectoryTool
    {
        void Copy(string pSrcDir, string pDestDir);
    }
}
