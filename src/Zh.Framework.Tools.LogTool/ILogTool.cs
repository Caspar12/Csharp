using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zh.Framework.Tools.LogTool
{
    public interface ILogTool
    {
          void Info(string pMsg);
          void Info(string pMsg, Exception pException);
    }
}
