using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Contracts.Factories.Common;
using req = InstantRemote.Core.Dtos.Common.Request;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Dtos;
using InstantRemote.Core.EntitiesStore.Common;
using Microsoft.AspNetCore.Authorization;

namespace InstantRemote.Api.Controllers.Common
{
    [ApiController]
    [Produces(Constants.ContentType)]
    [Route(Constants.RouteFiltro, Name = Constants.Filtros)]
    public class FiltrosController : BaseController
    {
        public FiltrosController(Func<string, IServiceFactory> serviceFactory) : base(serviceFactory)
        {
        }
            

    }
}
