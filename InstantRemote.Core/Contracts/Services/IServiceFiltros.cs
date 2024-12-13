

using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceFiltros
    {
        List<GetCatZonaClientesRespDto> GetCatZonaClientes (string emplid);
        List<GetCatZonaClientesRespDto> GetClientesXPermisos(int emplid);
        List<GetSucursalesRespDto> GetSucursalList(string clientId);
        List<GetSucursalesRespDto> GetSucursalesXPermisos(int emplid, string cliente);

        List<GetSeccionesRespDto> GetSeccion(int clientId, string otro);
        
        List<GetSitesRespDto> GetSites(int clientId, string otro);

        List<GetServicioRespDto> GetServicios(int clientId, string otro);

    }
}
