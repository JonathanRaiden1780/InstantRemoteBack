

using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceParameter
    {
      //  List<CatalogDto> GetParameterByGroup(string group);
        GetParameter GetParameterByReference(ParameterDto parameter);
    }
}
