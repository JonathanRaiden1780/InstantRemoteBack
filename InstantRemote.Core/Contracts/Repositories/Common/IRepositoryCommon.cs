using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryCommon
    {
        List<GetResponsablesRespDto> GetResponsables();
        List<GetYearResp> GetYears();
        List<GetWeekResp> GetWeeks (int year);
        void InsertBitacoraInstantRemote (BitacoraRequestDto  bitacora);
        List<TelefonosSucursalN> GetTelefonos(int idSucursal, string empleado);
        List<GetConstEnrolaRsp> GetConstEnrola(int tipo);
        List<GetDispositivosResp> GetDispositivos(int emplid);
        List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie);
        List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter);
        List<GetCatZonaClientesRespDto> GetClienteSeccion(int emplid);
        List<GetCatZonaClientesRespDto> GetClienteSite(int emplid);
        List<GetCatZonaClientesRespDto> GetClienteJerarquiaOtro(int emplid);
        List<GetClienteCatalogoRespDto> GetCatalogoCliente();
        List<GetClienteCatalogoRespDto> GetClienteSecciones(int emplid, int otro);
        bool InsertCliente(CatalogoClienteReqDto dataCliente);
        bool UpdateCliente(CatalogoClientUpdateeReqDto dataCliente);
        bool DeleteCliente(int idCliente);
        
        List<GetSucursalesRespDto> GetSucursales(string parameter);
        List<GetAllSucursalRes> GetAllSucursales(int emplid);
        void UpdateMasivoSucursales(string sucursales);

        List<GetSucursalesRespDto> GetSucursalesSeccion(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalesSite(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalesJerarquiaOtro(int emplid, string cliente);
        List<GetSucursalesRespDto> GetSucursalSecciones(int emplid, int seccion);
        List<CatalogoSucursaRespDto> GetSucursalCatalogo(int cliente, int sucursal);
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
        List<MenusEmpleado> GetMenusPermisosEmpleado(string numEmpleado);
        bool InsertPermisosEmpleado(InsertPermisosEmpleadoReq permisos);
        void UpdatePermisosEmpleado(UpdatePermisoEmpleadoReq permisos);
        bool DeletePermisosEmpleado(string numEmpleado);
        List<GetSeccionesEmpleadoRes> GetSeccionesEmpleado(string numEmpleado);
        List<GetSucursalEmpleadoClientesRes> GetSucursalEmpleadoClientes(GetSucursalEmpleadoClientesReq empleado);



                List<GetSitesRespDto> GetSites(int emplid, string cliente);
        List<GetSitesRespDto> GetSitesCliente(int emplid, string cliente);
        List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal);

        List<GetSeccionesRespDto> GetSecciones(int emplid, string otro);
        List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int sucursal);
        List<GetSeccionesRespDto> GetSeccion();
        List<DetalleResponsableRespDto> GetResponsablesDetalles(string Parametros);
        List<DetalleHorariosRespDto> GetHorariosDetalles(int sucursal);
        List<DetalleTelefonosRespDto> GetTelefonosDetalles(int sucursal);
        List<DetalleSitesRespDto> GetSitesDetalles(int sucursal);
        List<DetalleBiometricosRespDto> GetBiometricosDetalles(int sucursal);
        
        List<GetServicioRespDto> GetServicio(int emplid, string otro);
        List<GetServicioRespDto> GetServicioSucursal(int emplid, int sucursal);
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

        List<EmpleadosRes> GetEmpleados(EmpleadosReq empleado);
        List<EmpleadosDetalleRes> GetEmpleadosDetalle(string numEmpleado);
        List<EmpleadosCatalogo> GetEmpleadosCatalogos(string numEmpleado, string numEmpleadoSearch);
        List<EmpleadosCatalogoTelefonos> GetEmpleadosCatalogoTelefonos(string telefono);
        List<EmpleadosCatalogoEstatus> GetEmpleadosCatalogoEstatus(string numEmpleado, string estatus);
        int UpdateEmpleadosCatalogo(UpdateEmpleadosCatalogo empleado);
        
        void UpdateMasivoEmpleados(string empleado);
        List<DiasFestivosCatalogo> GetDiasFestivos();
        bool AddDiaFestivo(DiasFestivosCatalogoReqAddDto fecha);
        bool UpdateDiasFestivos(DiasFestivosCatalogoUpdate fecha);
        bool DeleteDiasFestivos(int id);

        List<GetHorariosAsignaRes> GetHorariosAsigna(string cliente, string sucursal);
        List<GetListaAsignaRes> GetListaHorariosAsigna(GetListaAsignaReq asigna);
        List<GetListaAsignaRes> GetListaHorariosAsignaEdit(GetListaAsignaUpReq asigna);
        int AddAsignacionTemp(AsignacionReq asigna);
        int UpdateAsignacionTemp(AsignacionReq asigna);
        int DeleteAsignacionTemp(AsignacionDelReq asigna);
    }
}
