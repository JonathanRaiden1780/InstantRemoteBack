using System;
using System.Text;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using InstantRemote.Core.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using InstantRemote.Core.Contracts.Factories.Common;
using sec = InstantRemote.Security;
using InstantRemote.Core.Mapping.Common;
using InstantRemote.Repositories;
using enums = InstantRemote.Core.Enums;

namespace InstantRemote.Api.Extensions
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddInyeccionDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCorsSpecificOriginsPolicy(configuration);
            services.AddServiceAuthApi();
            services.AddAutoMap();
            services.DependencyInjection();
            //services.HostedService();
            services.AddServiceFactories();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
        private static IServiceCollection AddServiceAuthApi(this IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opciones => opciones.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable(Constants.SecretKey))
                    ),
                    ClockSkew = TimeSpan.Zero
                });


            return services;
        }
        private static IServiceCollection AddAutoMap(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(MC =>
            {
                MC.AddProfile<ParameterAutoMapping>();
                MC.AddProfile<EntitiesAutoMapping>();
                MC.AddProfile<CommonAutoMapping>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
        private static IServiceCollection DependencyInjection(this IServiceCollection services)
        {
           // services.AddScoped<IServiceFactorySecurity, sec.ServiceFactory>();
            return services;
        }
        private static IServiceCollection AddServiceFactories(this IServiceCollection services)
        {
            services.AddScoped<Func<string, IServiceFactory>>(serviceFactory => key =>
            {
                return key switch
                {
                   // nameof(enums.Towers.Individual) => serviceFactory.GetService<camCI.ServiceFactory>(),
                   // nameof(enums.Towers.Investment) => serviceFactory.GetService<camIN.ServiceFactory>(),
                   // nameof(enums.Towers.AccountState) => serviceFactory.GetService<camAS.ServiceFactory>(),
                   // nameof(enums.Towers.Insurance) => serviceFactory.GetService<camIT.ServiceFactory>()
                };
            });

            return services;
        }
    }
}
