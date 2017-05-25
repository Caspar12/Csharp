using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Cache.Entities;

namespace Zh.Framework.Cache.Imp
{
    public abstract class AbstractCache : ICache
    {
        protected abstract CacheDto GetCache(string key);
        protected abstract void SetCache(CacheDto cacheDto);
        protected abstract void AddCache(CacheDto cacheDto);

        public abstract void Remove(string key);
        public abstract bool ContainsKey(string key);
        public T Get<T>(string key)
        {
            var cacheDto = GetCache(key);
            if (cacheDto == null) return default(T);
            if (cacheDto.Expire.HasValue && cacheDto.Expire.Value <= DateTime.Now)
            {
                Remove(key);
                return default(T);
            }
            return (T)cacheDto.Value;
        }

        public void Set(string key, object value)
        {
            Set(key, value, DateTime.MaxValue);
        }

        public void Set(string key, object value, DateTime expire)
        {

            var cacheDto = new CacheDto();
            cacheDto.Key = key;
            cacheDto.Value = value;
            cacheDto.Expire = expire;
            if (ContainsKey(key))
            {
                SetCache(cacheDto);
            }
            else
            {
                AddCache(cacheDto);
            }
        }

        public object Get(string key)
        {
            var cacheDto = GetCache(key);
            if (cacheDto == null) return null;
            if (cacheDto.Expire.HasValue && cacheDto.Expire.Value <= DateTime.Now)
            {
                Remove(key);
                return null;
            }
            return cacheDto.Value;
        }
    }
}
