using System.Reflection;
using Microsoft.OpenApi.Models;
using InstantRemote.Core.Helpers;
using Swashbuckle.AspNetCore.Filters;

namespace InstantRemote.Api.Extensions.Swagger
{
    public static class ServiceSwagger
    {
        public static IServiceCollection AddServiceSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(Constants.Security, new OpenApiInfo
                {
                    Version = Constants.ServiceVersion,
                    Title = Constants.SecurityTitle
                });

              


                c.AddSecurityDefinition(Constants.Bearer, new OpenApiSecurityScheme
                {
                    Name = Constants.DefinitionName,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = Constants.Bearer,
                    BearerFormat = Constants.BearerFormat,
                    In = ParameterLocation.Header
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = Constants.Bearer
                            }
                        },
                        new string[]{}
                    }
                });

                c.OperationFilter<CustomHeaderSwaggerAttribute>();
                c.OperationFilter<CustomQuerySwaggerAttribute>();
                c.ExampleFilters();
                c.CustomSchemaIds(x => x.Name.Replace(Constants.Dto, string.Empty));

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}{Constants.SwaggerExtensionXml}";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddSwaggerExamplesFromAssemblyOf<Startup>();

            return services;
        }
    }
}
