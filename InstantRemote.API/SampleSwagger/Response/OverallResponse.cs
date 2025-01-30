using InstantRemote.Core.Dtos.Common.Response;
using Swashbuckle.AspNetCore.Filters;

namespace InstantRemote.Api.SampleSwagger.Response
{
    public class OverallResponse
    {
    }


    public class SampleFunctionalErrorResponse : IExamplesProvider<FunctionalErrorMessageDto>
    {
        public FunctionalErrorMessageDto GetExamples()
        {
            return new CriticalErrorMessageDto
            {
                Exception = "Error en Server",
            };
        }
    }
}
