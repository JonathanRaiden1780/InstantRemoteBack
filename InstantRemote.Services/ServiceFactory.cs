using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using Microsoft.Extensions.Configuration;
using InstantRemote.Services.Parameters;
using InstantRemote.Services.Filtros;
using InstantRemote.Services.Common;

namespace InstantRemote.Services
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IUnitOfWork UnitOfWork = null;
        private readonly IMapper mapper = null;
        private readonly Func<string, IServiceFactory> serviceFactory = null;
        protected readonly IConfiguration configuration;

        private IServiceParameter serviceParameter = null;
        private IServiceFiltros serviceFiltros = null;
        private IServiceCommon serviceCommon = null;


        public ServiceFactory(IUnitOfWork unitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper, IConfiguration configuration)
        {
            UnitOfWork = unitOfWork;
            this.mapper = mapper;
            this.serviceFactory = serviceFactory;
            this.configuration = configuration;
        }

        public IServiceParameter ServiceParameter => serviceParameter ??= new ServiceParameter(UnitOfWork, serviceFactory, mapper);
        public IServiceFiltros ServiceFiltros => serviceFiltros ??= new ServiceFiltros(UnitOfWork, serviceFactory, mapper);
        public IServiceCommon ServiceCommon => serviceCommon ??= new ServiceCommon(UnitOfWork, serviceFactory, mapper);
    }
}
