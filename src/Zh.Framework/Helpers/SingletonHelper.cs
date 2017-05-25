using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Entities;

namespace Zh.Framework.Helpers
{
    public class SingletonHelper
    {
        static Dictionary<string, object> Caches = new Dictionary<string, object>();
        static object SyncObj = new object();
        public static T GetInstance<T>() where T : new()
        {
            var type = typeof(T);
            var key = type.FullName;
            if (Caches.ContainsKey(key))
            {
                return (T)Caches[key];
            }
            lock (SyncObj)
            {
                if (Caches.ContainsKey(key))
                {
                    return (T)Caches[key];
                }
                T value = new T();
                Caches.Add(key, value);
                return value;
            }
        }

        public static T GetInstance<T>(string key, ZhFunc<T> fun)
        {
            if (Caches.ContainsKey(key))
            {
                return (T)Caches[key];
            }
            lock (SyncObj)
            {
                if (Caches.ContainsKey(key))
                {
                    return (T)Caches[key];
                }
                T value = fun();
                Caches.Add(key, value);
                return value;
            }
        }
    }
}
