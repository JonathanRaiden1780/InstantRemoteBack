

using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceParameter
    {
        void InsertBitacora(BitacoraRequestDto bitacora);
        List<GetParameter> GetParameterByGroup(string group);
        GetParameter GetParameter(ParameterDto parameter);
        GetParameter GetParameterByReference(string reference);
    }
}
