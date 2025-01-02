using InstantRemote.Core.Contracts.Factories.Common;
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
        List<DetalleHorariosRespDto> GetHorariosDetalles(int sucursal);
        List<DetalleTelefonosRespDto> GetTelefonosDetalles(int sucursal);
        List<DetalleSitesRespDto> GetSitesDetalles(int sucursal);
        List<DetalleBiometricosRespDto> GetBiometricosDetalles(int sucursal);
        List<DetalleResponsableRespDto> GetResponsablesDetalles(string Parametros);
        List<TelefonosSucursalN> GetTelefonosSucursal(int idSucursal, string empleado);
        List<SitesSucursalN> GetSitesSucursalN(int idSucursal);
        List<BioSucursalN> GetBioSucursalN(int idSucursal);
        List<GetCandados> GetCandado();
        bool InsertTelefonoSucursal(NewTelefonoSucursal telefono);
        bool InsertSucursal(SucursalInsertDTO sucursal);
        bool UpdateSucursal(SucursaUpdateDto sucursal);
        bool DeleteSucursal(int idSucursal);
        List<TelefonosSucursalN> GetTelefonosbyId(string tel);

        List<EmpleadoPermiso> GetEmpleadosCPermisos();
        List<EmpleadoSNPermiso> GetEmpleadosSNPermisos();
        List<MenuPermisosDto> GetMenusPermisos();
        
        List<GetSeccionesRespDto> GetSecciones(int clientId, string otro);
        List<GetSeccionesRespDto> GetSeccion();
        List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int otro);

        List<GetSitesRespDto> GetSites(int clientId, string otro);
        List<GetSitesRespDto> GetSitesCliente(int emplid, string otro);
        List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal);

        List<GetServicioRespDto> GetServicios(int clientId, string otro);
        List<GetServicioRespDto> GetServicioSucursal(int emplid, int otro);
        List<GetServicioRespDto> GetServicioSeccion(int emplid, int seccion);
        List<HorarioDTO> GetCatalogoHorario(int cliente, int idDeptoSucursal);
        List<TipoHorarioDto> GetTipoHorario();
        List<GetNivelHorario> GetNivelHorario();
        List<GetServicioHorario> GetServicioHorario();
        List<GetTipoCHorario> GetTipoCHorario();
        
        
        bool ActualizaCatHorario(ActualizaCatHorarioDto horario);
        bool InsertCatHorario(InsertaCatHorarioDTO horario);
        bool DeleteCatHorario(string idHorario);
        int SaveToken(TokenAdd token);
        bool LiberaToken(TokenMod token);
        bool DeleteToken(TokenMod token);
        List<CatalogoTokenDto> GetCatalogoToken(string emplid);

        List<EmpleadosCatalogo> GetEmpleadosCatalogos(string numEmpleado, string numEmpleadoSearch);
        List<EmpleadosCatalogoTelefonos> GetEmpleadosCatalogoTelefonos(string telefono);
        List<EmpleadosCatalogoEstatus> GetEmpleadosCatalogoEstatus(string numEmpleado, string estatus);
        int UpdateEmpleadosCatalogo(UpdateEmpleadosCatalogo empleado);
        void UpdateMasivoEmpleados(List<UpdateEmpleadosMasive> empleados);
        List<DiasFestivosCatalogo> GetDiasFestivos();
        bool AddDiaFestivo(DiasFestivosCatalogoReqAddDto fecha);
        bool UpdateDiasFestivos(DiasFestivosCatalogoUpdate fecha);
        bool DeleteDiasFestivos(int id);
        
    }
}
