using InstantRemote.Api.Middlewares;

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
