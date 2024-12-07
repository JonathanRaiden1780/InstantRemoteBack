using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryParameter
    {
        List<GetParameter> GetInternalServiceConfig(ServiceConfigDto parameter);
        GetParameter GetParameter(ParameterDto parameter);
        List<GetParameter> GetParametersByGroup(string group);
        GetParameter GetParameterById(int idParameter);

    }
}
