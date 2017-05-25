using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Cache.Entities;

namespace Zh.Framework.Cache.Imp
{
    public class MemoryCache : AbstractCache, ICache
    {
        Dictionary<string, CacheDto> _cache = new Dictionary<string, CacheDto>();  
  

        protected override CacheDto GetCache(string key)
        {
            return ContainsKey(key) ? _cache[key] : null;
        }

        protected override void SetCache(CacheDto cacheDto)
        {
            _cache[cacheDto.Key] = cacheDto;
        }

        protected override void AddCache(CacheDto cacheDto)
        {
            _cache.Add(cacheDto.Key, cacheDto);
        }

        public override void Remove(string key)
        {
            _cache.Remove(key);
        }

        public override bool ContainsKey(string key)
        {
            return _cache.ContainsKey(key);
        }
    }
}
