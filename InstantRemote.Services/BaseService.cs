using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using Microsoft.Extensions.Configuration;

namespace InstantRemote.Services
{
    public class BaseService
    {
        protected readonly IMapper mapper;
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly Func<string, IServiceFactory> serviceFactory;

        protected BaseService(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.serviceFactory = serviceFactory;
            this.mapper = mapper;
        }

    }
}
