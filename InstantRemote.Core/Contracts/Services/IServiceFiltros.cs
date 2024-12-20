﻿using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceFiltros
    {
        List<GetResponsablesRespDto> GetResponsables();

        List<GetCatZonaClientesRespDto> GetCatZonaClientes (string emplid);
        List<GetCatZonaClientesRespDto> GetClientesXPermisos(int emplid);
        List<GetClienteCatalogoRespDto> GetCatalogoCliente();
        List<GetClienteCatalogoRespDto> GetClienteSecciones(int emplid, int otro);
        bool InsertCliente(CatalogoClienteReqDto dataCliente);
        bool UpdateCliente(CatalogoClientUpdateeReqDto dataCliente);
        bool DeleteCliente(int idCliente);
        List<GetSucursalesRespDto> GetSucursalList(string clientId);
        List<GetSucursalesRespDto> GetSucursalesXPermisos(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalSecciones(int emplid, int secciones);
        List<CatalogoSucursaRespDto> GetSucursalCatalogo(int cliente, int sucursal);

        List<GetSeccionesRespDto> GetSeccion(int clientId, string otro);
        List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int otro);

        List<GetSitesRespDto> GetSites(int clientId, string otro);
        List<GetSitesRespDto> GetSitesCliente(int emplid, string otro);
        List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal);

        List<GetServicioRespDto> GetServicios(int clientId, string otro);
        List<GetServicioRespDto> GetServicioSucursal(int emplid, int otro);
        List<GetServicioRespDto> GetServicioSeccion(int emplid, int seccion);
    }
}
