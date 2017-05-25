using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.CryptogramTool
{
    public interface ICryptogramTool
    {
        string SHA1(string orgStr, string encode = "UTF-8");
        string MD5(string encypStr, string charset = "UTF-8");
    }
}
