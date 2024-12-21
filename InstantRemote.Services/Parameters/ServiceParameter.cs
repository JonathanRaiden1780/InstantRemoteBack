using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Services.Parameters
{
    public class ServiceParameter : BaseService, IServiceParameter
    {
        public ServiceParameter(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }
        public void InsertBitacora(BitacoraRequestDto bitacora)
        {
            UnitOfWork.RepositoryCommon.InsertBitacoraInstantRemote(bitacora);
        }

        public List<GetParameter> GetParameterByGroup(string group)
        {
            return UnitOfWork.RepositoryParameter.GetParametersByGroup(group);
        }

        public GetParameter GetParameter(ParameterDto parameter)
        {
            var getParameter = UnitOfWork.RepositoryParameter.GetParameter(parameter);
            return getParameter;
        }

        public GetParameter GetParameterByReference(string reference)
        {
            var getParameter = UnitOfWork.RepositoryParameter.GetParameterByReference(reference);
            return getParameter;
        }

    }
}
