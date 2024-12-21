using AutoMapper;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Security.Services
{
    public class BaseService
    {
        protected readonly IServiceFactorySecurity serviceFactorySecurity;
        protected readonly IConfiguration configuration;
        protected readonly Func<string, IServiceFactory> serviceFactory;
        protected readonly IMapper mapper;
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly string SecretKey;
        protected readonly int expiracionMinutos;

        protected BaseService(IUnitOfWork UnitOfWork, IServiceFactorySecurity serviceFactorySecurity, Func<string, IServiceFactory> serviceFactory , IMapper mapper, IConfiguration configuration)
        {
            this.UnitOfWork = UnitOfWork;
            this.serviceFactorySecurity = serviceFactorySecurity;
            this.serviceFactory = serviceFactory;
            this.mapper = mapper;
            this.SecretKey = Environment.GetEnvironmentVariable(Constants.SecretKey);
            this.expiracionMinutos = Convert.ToInt32(configuration[Constants.ExpirationMinutes]);
        }

    
    }
}
