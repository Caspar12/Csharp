using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Tools.EntityTool.BindingTool.NVCollectionBinder
{
    public interface INVCollectionBinder
    {
        T Bind<T>();

        T Bind<T>(T pObj);

        object Bind(Type type);

        object Bind(object obj);
    }
}
