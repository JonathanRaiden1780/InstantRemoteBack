

using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceParameter
    {
        List<GetParameter> GetParameterByGroup(string group);
        GetParameter GetParameter(ParameterDto parameter);
        GetParameter GetParameterByReference(string reference);
    }
}
