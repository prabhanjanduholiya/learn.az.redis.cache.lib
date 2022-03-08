using learn.az.redis.cache.lib.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.az.redis.cache.lib
{
    public class TextCacheManager : ITextCacheManager
    {
        IConnectionMultiplexer _redis;

        public TextCacheManager(IConnectionMultiplexer connectionMultiplexer)
        {
            _redis = connectionMultiplexer;
        }

        public async Task<bool> Set(string key, string value)
        {
            var db = _redis.GetDatabase();

            var result = await db.StringSetAsync(key, value);

            return await Task.FromResult(result);
        }

        public async Task<string> GetAsync(string key)
        {
            var db = _redis.GetDatabase();

            var result = db.StringGet(key);

            return await Task.FromResult(result);
        }


    }
}
