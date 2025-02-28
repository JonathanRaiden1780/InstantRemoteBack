﻿using System.Linq;
using InstantRemote.Core.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstantRemote.Api.Extensions
{
    public static class ServiceCorsSpecificOriginsPolicy
    {
        public static void AddCorsSpecificOriginsPolicy(this IServiceCollection services, IConfiguration configuration)
        {
            string[] paramUrl = configuration.GetSection(Constants.OriginsPolicy).GetChildren().Select(i => i.Value).ToArray();

            services.AddCors(options => {
                options.AddPolicy(name: Constants.OriginsPolicy, builder => { builder.WithOrigins(paramUrl).AllowAnyHeader().AllowAnyMethod(); });
            });
        }
    }
}
