using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Cache
{
    public interface ICache
    {
        T Get<T>(string key);
        object Get(string key);
        void Set(string key, object value);

        void Set(string key, object value, DateTime expire);

        void Remove(string key);

        bool ContainsKey(string key);
    }
}
