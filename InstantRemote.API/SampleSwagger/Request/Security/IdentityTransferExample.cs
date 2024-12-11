using InstantRemote.Core.Dtos.Common.Request;
using Swashbuckle.Examples;

namespace InstantRemote.Api.SampleSwagger.Request.Security
{
    public class IdentityTransferExample : IExamplesProvider
    {
        public object GetExamples()
        {

            return new AuthenticationDto {
                User = "0000",
               Password = "1234",

            };
        }    
    }

    
}
