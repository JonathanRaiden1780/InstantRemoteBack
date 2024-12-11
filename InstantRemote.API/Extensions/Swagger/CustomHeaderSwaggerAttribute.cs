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


         //   bool webhookDigipro = context.ApiDescription.RelativePath.Contains(Constants.WebhookDigipro);
            bool identityTransfer = context.ApiDescription.RelativePath.Contains(Constants.IdentityTransfer);
            bool generate = context.ApiDescription.RelativePath.Contains(Constants.GenerateRedirect);


            if ( identityTransfer || generate)
            {
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = Constants.UserAccessControl,
                    In = ParameterLocation.Header,
                    Required = true,
                    Schema = new OpenApiSchema { Type = Constants.String }
                });

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = Constants.TchAccessControl,
                    In = ParameterLocation.Header,
                    Required = true,
                    Schema = new OpenApiSchema { Type = Constants.String }
                });
            }
        }
    }
}
