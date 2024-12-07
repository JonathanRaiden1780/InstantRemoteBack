using Microsoft.AspNetCore.Builder;
using InstantRemote.Core.Helpers;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.Extensions.Configuration;

namespace InstantRemote.Api.Extensions.Swagger
{
    public static class ConfigureSwaggerUIOptionsExt
    {
        public static SwaggerUIOptions AddSwaggerEndpointsPath(this SwaggerUIOptions c, IConfiguration configuration)
        {
            var key = Constants.CustomSwaggerUi;
            string pahtCssSwagger = configuration.GetSection(key).Value;            
            string virtualDirectory = configuration.GetSection(Constants.VirtualDirectory).Value;

            c.SwaggerEndpoint(Constants.SwaggerPathSeguridad, Constants.SecurityTitle);

#if DEBUG
            pahtCssSwagger = pahtCssSwagger.Replace(virtualDirectory, string.Empty);
#endif

            c.InjectStylesheet(pahtCssSwagger);
            return c;
        }
    }
}
