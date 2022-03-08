using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.az.redis.cache.lib.Interfaces
{
    public interface ITextCacheManager
    {
        Task<bool> Set(string key, string value);

        Task<string> GetAsync(string key);
    }
}
