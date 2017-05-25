using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.ConfigTool
{
    public interface IConfigTool
    {
        T Get<T>();
    }
}
