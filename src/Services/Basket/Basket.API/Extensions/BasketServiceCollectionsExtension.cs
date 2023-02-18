using System;
using Microsoft.Extensions.Configuration;

namespace Basket.API.Extensions
{
	public static class BasketServiceCollectionsExtension
	{
        
        public static void AddBasketVerification(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDataProtection();
            services.AddHttpContextAccessor();

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
        }

    }
}
