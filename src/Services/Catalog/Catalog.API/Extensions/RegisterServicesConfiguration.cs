using System;
using Catalog.API.Data;
using Catalog.API.Repositories;

namespace Catalog.API.Extensions
{
	public static class RegisterServicesConfiguration
	{
        public static void AddRegisterServices(this IServiceCollection services, IConfiguration configure)
        {
            services.AddCors(o =>
            {
                o.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    );
            });

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICatalogContext, CatalogContext>();

        }
    }
}

