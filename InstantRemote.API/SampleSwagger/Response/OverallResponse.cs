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
                Url = "https://came.techreo.com.mx/FunctionalError?trackingCode=06e9dbce-cdcf-4960-a6f1-0c806f38444f",
            };
        }
    }
}
