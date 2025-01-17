

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
        bool UpdateParameter(string reference, string value);
        List<GetCP> GetCP(int estado, int mun, int col);
        List<GetMunicipio> GetMunicipio(int estado);
        List<GetColonia> GetColonia(int estado, int mun);
        List<GetEstados> GetEstados();
        List<GetZonaHoraria> GetZonaHoraria();
    }
}
