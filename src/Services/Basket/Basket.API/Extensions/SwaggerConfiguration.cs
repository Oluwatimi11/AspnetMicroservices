﻿using System;
using Microsoft.OpenApi.Models;

namespace Basket.API.Extensions
{
	public static class SwaggerConfiguration
	{
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Basket.API",
                    Version = "v1"
                });
                // Set the comments path for the Swagger JSON and UI.
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // setupAction.IncludeXmlComments(xmlPath);
            });
        }
    }
}

