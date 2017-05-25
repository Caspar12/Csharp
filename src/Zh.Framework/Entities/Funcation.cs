using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Entities
{
    public delegate T ZhFunc<T>();
    public delegate T ZhFunc<T, T1>(T1 obj);
    public delegate T ZhFunc<T, T1, T2>(T1 obj, T2 obj2);
}
