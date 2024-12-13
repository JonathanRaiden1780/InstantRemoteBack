using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryCommon
    {
        void InsertBitacoraInstantRemote (BitacoraRequestDto  bitacora);

        List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter);
        List<GetCatZonaClientesRespDto> GetClienteSeccion(int emplid);
        List<GetCatZonaClientesRespDto> GetClienteSite(int emplid);
        List<GetCatZonaClientesRespDto> GetClienteJerarquiaOtro(int emplid);

        List<GetSucursalesRespDto> GetSucursales(string parameter);
        List<GetSucursalesRespDto> GetSucursalesSeccion(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalesSite(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalesJerarquiaOtro(int emplid, string cliente);

        List<GetSitesRespDto> GetSites(int emplid, string cliente);
        List<GetSeccionesRespDto> GetSecciones(int emplid, string otro);
        List<GetServicioRespDto> GetServicio(int emplid, string otro);
    }
}
