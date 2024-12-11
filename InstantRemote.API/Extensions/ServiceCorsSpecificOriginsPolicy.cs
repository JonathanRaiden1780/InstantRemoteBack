using InstantRemote.Core.Helpers;

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
