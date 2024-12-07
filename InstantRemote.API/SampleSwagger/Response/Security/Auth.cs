using Swashbuckle.AspNetCore.Filters;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Api.SampleSwagger.Response.Security
{
    public class Auth : IExamplesProvider<SignInDto>
    {
        public SignInDto GetExamples()
        {

            return new SignInDto
            {
                Url = "https://came.techreo.com.mx/custom-redirect?seed=06e9dbcecdcf4960",
                Message = "OK"
            };
        }
    }
}
