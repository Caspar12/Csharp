using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Framework.Cache.Helpers
{
    /// <summary>
    /// 集合类型缓存帮助类
    /// </summary>
    public class CacheCollectionHelper
    {
        ICache iCache;
        string collectionKey;

        string itemKeysCacheKey
        {
            get
            {
                return this.collectionKey + "_" + "itemKeys";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iCache">缓存实存接口</param>
        /// <param name="collectionKey">集合类型缓存主键</param>
        public CacheCollectionHelper(ICache iCache, string collectionKey)
        {
            this.iCache = iCache;
            this.collectionKey = collectionKey;
            var cacheItemKeys = this.iCache.Get<List<string>>(this.itemKeysCacheKey);
            if (cacheItemKeys == null)
            {
                this.iCache.Set(itemKeysCacheKey, new List<string>());
            }
        }
        string GetItemKey(string key)
        {
            return this.collectionKey + "_item_" + key;
        }

        public void Set(string key, object value)
        {
            Set(key, value, null);
        }
        public void Set(string key, object value, DateTime? expire)
        {
            var itemKey = GetItemKey(key);
            AddItemKey(itemKey);
            if (expire.HasValue)
            {
                this.iCache.Set(itemKey, value, expire.Value);
            }
            else
            {
                this.iCache.Set(itemKey, value);
            }
        }
        public void Set(string key, object value, DateTime expire)
        {
            Nullable<DateTime> d = new Nullable<DateTime>(expire);
            Set(key, value, d);
        }

        private List<string> GetItemKeys()
        {
            return this.iCache.Get<List<string>>(this.itemKeysCacheKey);
        }
        private void AddItemKey(string newItemKey)
        {
            var itemKeys = GetItemKeys();
            foreach (var itemKey in itemKeys)
            {
                if (newItemKey == itemKey)
                {
                    return;
                }
            }
            itemKeys.Add(newItemKey);
            this.iCache.Set(this.itemKeysCacheKey, itemKeys);
        }

        public void Clear()
        {
            var itemKeys = new List<string>(GetItemKeys().ToArray());
            foreach (var itemKey in itemKeys)
            {
                this.RemoveByItemKey(itemKey);
            }
        }

        private void RemoveItemKey(string itemKey)
        {
            var itemKeys = GetItemKeys();
            itemKeys.Remove(itemKey);
            this.iCache.Set(this.itemKeysCacheKey, itemKeys);
            this.iCache.Remove(itemKey);
        }

        public void Remove(string key)
        {
            var itemKey = GetItemKey(key);
            RemoveByItemKey(itemKey);
        }
        void RemoveByItemKey(string itemKey)
        {
            RemoveItemKey(itemKey);
        }
        public object Get(string key)
        {
            var itemKey = this.GetItemKey(key);
            return this.iCache.Get(itemKey);
        }
        public T Get<T>(string key)
        {
            var obj = Get(key);
            if (obj == null) return default(T);
            return (T)obj;
        }
    }
}
