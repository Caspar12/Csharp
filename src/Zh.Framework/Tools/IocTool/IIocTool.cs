using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.IocTool
{
    public interface IIocTool
    {
        T Get<T>() where T : class;
        T Get<T>(string id) where T : class;
        object Get(Type type);

       
    }
}
