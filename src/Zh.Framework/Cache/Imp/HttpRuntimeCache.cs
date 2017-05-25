using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Zh.Framework.Cache.Imp
{
    public class HttpRuntimeCache : ICache
    {
        public bool ContainsKey(string key)
        {
            return true;
        }

        public object Get(string key)
        {
            return HttpRuntime.Cache.Get(key);
        }

        public T Get<T>(string key)
        {
            var obj = HttpRuntime.Cache.Get(key);
            if (obj == null) return default(T);
            return (T)obj;
        }


        public void Remove(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }

        public void Set(string key, object value)
        {
            if (value == null) return;
            HttpRuntime.Cache.Insert(key, value);
        }

        public void Set(string key, object value, DateTime expire)
        {
            if (value == null) return;
            HttpRuntime.Cache.Insert(key, value, null, expire, System.Web.Caching.Cache.NoSlidingExpiration);
        }
    }
}
