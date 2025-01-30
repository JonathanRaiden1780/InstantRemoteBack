using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryParameter
    {
        GetParameter GetParameter(ParameterDto parameter);
        List<GetParameter> GetParametersByGroup(string group);
        GetParameter GetParameterById(int idParameter);
        bool UpdateParameter(string reference, string value);
        GetParameter GetParameterByReference(string reference);
        List<GetCP> GetCP(int estado, int mun, int col);
        List<GetMunicipio> GetMunicipio(int estado);
        List<GetColonia> GetColonia(int estado, int mun);
        List<GetEstados> GetEstados();
        List<GetZonaHoraria> GetZonaHoraria();
    }
}
