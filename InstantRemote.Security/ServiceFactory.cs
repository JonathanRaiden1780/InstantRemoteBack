using AutoMapper;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Security.Services;

namespace InstantRemote.Security
{
    public class ServiceFactory : IServiceFactorySecurity
    {
        private readonly IUnitOfWork UnitOfWork = null;
        private readonly IMapper mapper = null;
        private readonly IConfiguration configuration = null;
        private readonly Func<string, IServiceFactory> serviceFactory = null;

        private IServiceAuth serviceAuth = null;

        public ServiceFactory(IUnitOfWork unitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper, IConfiguration configuration)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
            this.configuration = configuration;
            this.serviceFactory = serviceFactory;
        }

        public IServiceAuth ServiceAuth => serviceAuth ??= new ServiceAuth(UnitOfWork, serviceFactory, this, mapper, configuration);

    }
}
