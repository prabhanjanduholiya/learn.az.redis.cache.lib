using learn.az.redis.cache.lib.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.az.redis.cache.lib
{
    public class RedisConfigurationManager
    {
        public static void AddRedis(IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IConnectionMultiplexer>(opt => ConnectionMultiplexer.Connect(connectionString));

            services.AddScoped<ITextCacheManager, TextCacheManager>();
        }
    }
}
