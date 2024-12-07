using InstantRemote.Api.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace InstantRemote.Api.Extensions
{
    public static class ConfigureMiddelwares
    {
        public static IApplicationBuilder AddCustomsMiddelwares(this IApplicationBuilder app)
        {
            app.UseMiddleware<MiddlewareHeaders>();

            return app;
        }
    }
}
