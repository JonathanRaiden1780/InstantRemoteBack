using InstantRemote.Core.Helpers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace InstantRemote.Api.Extensions.Swagger
{
    public class CustomQuerySwaggerAttribute : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();


            bool getCatalog = context.ApiDescription.RelativePath.Contains(Constants.GetCatalog);

            if (getCatalog)
            {
                var parameter = operation.Parameters.FirstOrDefault(x => x.Name.Equals(Constants.QueryProductId));
                parameter.Required = true;
            }

                
        }
    }
}
