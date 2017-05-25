using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Cache.Entities;
using Zh.Framework.Session;

namespace Zh.Framework.Session.Impls
{
    public class MemorySession : ISession
    {
        static Dictionary<string, object> _cache = new Dictionary<string, object>();



        public object Get(string key)
        {
            if (_cache.ContainsKey(key))
                return _cache[key];
            else
                return null;
        }
 

        public void Set(string key, object value)
        {
            if (_cache.ContainsKey(key))
                _cache[key] = value;
            else
                _cache.Add(key, value);
        }

        public void Set(string key, object value, TimeSpan expire)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object value, DateTime expire)
        {
            throw new NotImplementedException();
        }
    }
}
