using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using Microsoft.Extensions.Configuration;
using InstantRemote.Services.Common.Parameters;

namespace InstantRemote.Services.Common
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IUnitOfWork UnitOfWork = null;
        private readonly IMapper mapper = null;
        private readonly Func<string, IServiceFactory> serviceFactory = null;
        protected readonly IConfiguration configuration;

        private IServiceParameter serviceParameter = null;


        public ServiceFactory(IUnitOfWork unitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper, IConfiguration configuration)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
            this.serviceFactory = serviceFactory;
            this.configuration = configuration;
        }

        public IServiceParameter ServiceParameter =>   serviceParameter ??= new ServiceParameter(UnitOfWork, serviceFactory, mapper);
    }
}
