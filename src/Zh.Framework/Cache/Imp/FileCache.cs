using System;
using System.Collections.Generic;
using System.Text;
using Zh.Framework.Tools.SerializeTool;
using Zh.Framework.Tools.AppContextTool;
using Zh.Framework.Cache.Entities;

namespace Zh.Framework.Cache.Imp
{
    public class FileCache : AbstractCache, ICache
    {
        ISerializeTool _ISerializeTool;
        IAppContext _IAppContext;
        string CacheFileFullName
        {
            get;
            set;
        }

        Dictionary<string, CacheDto> GetCacheFromFile()
        {

            var cacheList = _ISerializeTool.DeserializeFromFile<List<CacheDto>>(GetCacheFilePath());
            if (cacheList == null)
            {
                cacheList = new List<CacheDto>();
            }
            Dictionary<string, CacheDto> cacheDict = new Dictionary<string, CacheDto>(cacheList.Count);
            foreach (var item in cacheList)
            {
                cacheDict.Add(item.Key, item);
            }
            return cacheDict;

        }

        string GetCacheFilePath()
        {
            return _IAppContext.GetMapPath(CacheFileFullName);
        }

        protected void SaveCacheFile(Dictionary<string, CacheDto> cacheDtos)
        {
            List<CacheDto> list = new List<CacheDto>(cacheDtos.Count);
            foreach (var item in cacheDtos.Values)
            {
                list.Add(item);
            }

            _ISerializeTool.SerializeToFile(list, GetCacheFilePath());
        }

        protected override CacheDto GetCache(string key)
        {
            var cacheDtos = GetCacheFromFile();
            return ContainsKey(key) ? cacheDtos[key] : null;
        }

        protected override void SetCache(CacheDto cacheDto)
        {
            var cacheDtos = GetCacheFromFile();
            cacheDtos[cacheDto.Key] = cacheDto;
            SaveCacheFile(cacheDtos);
        }

        protected override void AddCache(CacheDto cacheDto)
        {
            var cacheDtos = GetCacheFromFile();
            cacheDtos.Add(cacheDto.Key, cacheDto);
            SaveCacheFile(cacheDtos);

        }

        public override void Remove(string key)
        {
            var cacheDtos = GetCacheFromFile();
            cacheDtos.Remove(key);
            SaveCacheFile(cacheDtos);
        }

        public override bool ContainsKey(string key)
        {
            var cacheDtos = GetCacheFromFile();
            return cacheDtos.ContainsKey(key);
        }
    }
}
