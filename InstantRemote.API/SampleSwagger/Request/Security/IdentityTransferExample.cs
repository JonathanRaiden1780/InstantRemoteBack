using InstantRemote.Core.Dtos.Common.Request;
using Swashbuckle.AspNetCore;
using Swashbuckle.Examples;

namespace InstantRemote.Api.SampleSwagger.Request.Security
{
    public class IdentityTransferExample : IExamplesProvider
    {
        public object GetExamples()
        {

            return new AuthenticationDto {
                Email = "correo@dominio.com",
               Password = "1234",

            };
        }    
    }

    
}
