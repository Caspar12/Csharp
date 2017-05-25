/*
 * Author: 陈志杭 Caspar 
 * Contact: chensair@gmail.com qq:279397942
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.LanguageTool
{
    public interface ILanguageTool
    {
        string Get(string pKey, string pDefaultLang);
    }
}
