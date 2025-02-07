using InstantRemote.Core.Helpers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace InstantRemote.Api.Extensions.Swagger
{
    public class CustomHeaderSwaggerAttribute : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();
            
        }
    }
}
