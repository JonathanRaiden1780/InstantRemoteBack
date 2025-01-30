using Microsoft.AspNetCore.Mvc;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Api.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IServiceFactorySecurity serviceFactorySecurity;
        protected readonly Func<string, IServiceFactory> serviceFactory;
        protected readonly string Redirect404;

        protected BaseController(IServiceFactorySecurity serviceFactorySecurity)
        {
            this.serviceFactorySecurity = serviceFactorySecurity;
        }
        protected BaseController(IServiceFactorySecurity serviceFactorySecurity, IConfiguration configuration)
        {
            this.serviceFactorySecurity = serviceFactorySecurity;
            this.Redirect404 = configuration[Constants.Redirect404];
        }
        protected BaseController(Func<string, IServiceFactory> serviceFactory)
        {
            this.serviceFactory = serviceFactory;
        }
    }
}
