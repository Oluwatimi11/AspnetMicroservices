using System;
using Basket.API.Repositories;

namespace Basket.API.Extensions
{
	public static class RegisterServicesConfiguration
	{
        public static void AddRegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    );
            });

            //services.AddSingleton(Log.Logger);
            services.AddScoped<IBasketRepository, BasketRepository>();


            //services.AddHttpClient<IHttpClientService, HttpClientService>();
            //services.AddScoped<IHttpClientService, HttpClientService>();

        }
    }
}

