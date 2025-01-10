using System.Text;
using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Services.Filtros
{
    public class ServiceFiltros : BaseService, IServiceFiltros
    {
        public ServiceFiltros(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public List<GetResponsablesRespDto> GetResponsables()
        {
            return UnitOfWork.RepositoryCommon.GetResponsables();
        }
        
        public List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid)
        {
            List<GetCatZonaClientesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid);
            var admin = userPermiso.IdCliente.Contains(',') ? false :
                int.Parse(userPermiso.IdCliente) == 0 ? true : false;
            if (admin)
                response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid, null);
            else
                response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid, userPermiso.IdCliente);

            return response;
        }
        public List<GetCatZonaClientesRespDto> GetClientesXPermisos(int emplid)
        {
            List<GetCatZonaClientesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid.ToString());
            var nivel = userPermiso.IdCliente;

            switch (nivel)
            {
                case "0":
                    response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid.ToString(), null);
                    break;
                case "000":
                    response = UnitOfWork.RepositoryCommon.GetClienteSeccion(emplid);
                    break;
                case "000000":
                    response = UnitOfWork.RepositoryCommon.GetClienteSite(emplid);
                    break;
                default:
                    response = UnitOfWork.RepositoryCommon.GetClienteJerarquiaOtro(emplid);
                    break;
            }

            return response;
        }


        public List<GetClienteCatalogoRespDto> GetCatalogoCliente()
        {
            return UnitOfWork.RepositoryCommon.GetCatalogoCliente();
        }

        public List<GetClienteCatalogoRespDto> GetClienteSecciones(int emplid, int otro)
        {
            return UnitOfWork.RepositoryCommon.GetClienteSecciones(emplid, otro);
        }

        public bool InsertCliente(CatalogoClienteReqDto dataCliente)
        {
            return UnitOfWork.RepositoryCommon.InsertCliente(dataCliente);
        }
        public bool UpdateCliente(CatalogoClientUpdateeReqDto dataCliente)
        {
            return UnitOfWork.RepositoryCommon.UpdateCliente(dataCliente);
        }
        public bool DeleteCliente(int idCliente)
        {
            return UnitOfWork.RepositoryCommon.DeleteCliente(idCliente);
        }

        public List<GetSucursalesRespDto> GetSucursalList(string clientId)
        {
            return UnitOfWork.RepositoryCommon.GetSucursales(clientId);
        }

        public List<GetAllSucursalRes> GetAllSucursales()
        {
            return UnitOfWork.RepositoryCommon.GetAllSucursales();

        }

        public List<GetSucursalesRespDto> GetSucursalesXPermisos(int emplid, string cliente)
        {
            List<GetSucursalesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid.ToString());
            var nivel = userPermiso.IdCliente;

            switch (nivel)
            {
                case "0":
                    response = UnitOfWork.RepositoryCommon.GetSucursales(cliente);
                    break;
                case "000":
                    response = UnitOfWork.RepositoryCommon.GetSucursalesSeccion(emplid, cliente);
                    break;
                case "000000":
                    response = UnitOfWork.RepositoryCommon.GetSucursalesSite(emplid, cliente);
                    break;
                default:
                    response = UnitOfWork.RepositoryCommon.GetSucursalesJerarquiaOtro(emplid, cliente);
                    break;
            }

            return response;
        }


        public List<GetSucursalesRespDto> GetSucursalSecciones(int emplid, int secciones)
        {
            return UnitOfWork.RepositoryCommon.GetSucursalSecciones(emplid, secciones);
        }

        public List<CatalogoSucursaRespDto> GetSucursalCatalogo(int cliente, int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSucursalCatalogo(cliente, sucursal);
        }

        public List<DetalleHorariosRespDto> GetHorariosDetalles(int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetHorariosDetalles(sucursal);
        }

        public List<DetalleTelefonosRespDto> GetTelefonosDetalles(int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetTelefonosDetalles(sucursal);
        }

        public List<DetalleSitesRespDto> GetSitesDetalles(int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSitesDetalles(sucursal);
        }

        public List<DetalleBiometricosRespDto> GetBiometricosDetalles(int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetBiometricosDetalles(sucursal);
        }

        public List<DetalleResponsableRespDto> GetResponsablesDetalles(string Parametros)
        {
            return UnitOfWork.RepositoryCommon.GetResponsablesDetalles(Parametros);
        }

        public List<TelefonosSucursalN> GetTelefonosSucursal(int idSucursal, string empleado)
        {
            return UnitOfWork.RepositoryCommon.GetTelefonos(idSucursal, empleado);
        }

        public List<SitesSucursalN> GetSitesSucursalN(int idSucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSitesSucursalN(idSucursal);

        }
        public List<BioSucursalN> GetBioSucursalN(int idSucursal)
        {
            return UnitOfWork.RepositoryCommon.GetBioSucursalN(idSucursal);

        }
        public List<GetCandados> GetCandado()
        {
            return UnitOfWork.RepositoryCommon.GetCandado();
        }
        public bool InsertTelefonoSucursal(NewTelefonoSucursal telefono)
        {
            return UnitOfWork.RepositoryCommon.InsertTelefonoSucursal(telefono);
        }
        public bool InsertSucursal(SucursalInsertDTO sucursal)
        {
            return UnitOfWork.RepositoryCommon.InsertSucursal(sucursal);

        }
        public bool UpdateSucursal(SucursaUpdateDto sucursal)
        {
            return UnitOfWork.RepositoryCommon.UpdateSucursal(sucursal);

        }
        public bool DeleteSucursal(int idSucursal)
        {
            return UnitOfWork.RepositoryCommon.DeleteSucursal(idSucursal);

        }
        public void UpdateMasivoSucursal(List<UpdateSucursalMasive> sucursales)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            StringBuilder xmlBuilder = new StringBuilder();
            xmlBuilder.Append("<sucursales>");

            foreach (var sucursal in sucursales)
            {
                xmlBuilder.Append("<sucursal>");
                xmlBuilder.AppendFormat("<idDeptoSucursal>{0}</idDeptoSucursal>", sucursal.idDeptoSucursal);
                xmlBuilder.AppendFormat("<calle>{0}</calle>", sucursal.calle.Trim());
                xmlBuilder.AppendFormat("<numExt>{0}</numExt>", sucursal.numExt.Trim());
                xmlBuilder.AppendFormat("<numInt>{0}</numInt>", sucursal.numInt.Trim());
                xmlBuilder.AppendFormat("<colonia>{0}</colonia>", sucursal.colonia.Trim());
                xmlBuilder.AppendFormat("<cp>{0}</cp>", sucursal.cp.Trim());
                xmlBuilder.AppendFormat("<municipio>{0}</municipio>", sucursal.municipio.Trim());
                xmlBuilder.AppendFormat("<estado>{0}</estado>", sucursal.estado.Trim());
                xmlBuilder.AppendFormat("<latitud>{0}</latitud>", sucursal.latitud);
                xmlBuilder.AppendFormat("<longitud>{0}</longitud>", sucursal.longitud);
                xmlBuilder.AppendFormat("<error>{0}</error>", sucursal.error);
                xmlBuilder.AppendFormat("<idEmpleado>{0}</idEmpleado>", sucursal.idEmpleado);
                xmlBuilder.Append("</sucursal>");
            }

            xmlBuilder.Append("</sucursales>");
            string sucursalesXML = xmlBuilder.ToString();
            
            UnitOfWork.RepositoryCommon.UpdateMasivoSucursales(sucursalesXML);
        }
        

        public List<TelefonosSucursalN> GetTelefonosbyId(string tel)
        {
            return UnitOfWork.RepositoryCommon.GetTelefonosbyId(tel);
        }
        
        
        

        public List<GetSeccionesRespDto> GetSecciones(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSecciones(clientId, otro);
        }

        public List<GetSeccionesRespDto> GetSeccion()
        {
            return UnitOfWork.RepositoryCommon.GetSeccion();
        }
        public List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int otro)
        {
            return UnitOfWork.RepositoryCommon.GetSeccionesSucursales(emplid, otro);
        }

        public List<GetSitesRespDto> GetSites(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSites(clientId, otro);
        }

        public List<GetSitesRespDto> GetSitesCliente(int emplid, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSitesCliente(emplid, otro);
        }
        public List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSitesSucursal(emplid, sucursal);
        }

        public List<GetServicioRespDto> GetServicios(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetServicio(clientId, otro);
        }

        public List<GetServicioRespDto> GetServicioSucursal(int emplid, int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetServicioSucursal(emplid, sucursal);
        }

        public List<GetServicioRespDto> GetServicioSeccion(int emplid, int seccion)
        {
            return UnitOfWork.RepositoryCommon.GetServicioSeccion(emplid, seccion);

        }


        public List<HorarioDTO> GetCatalogoHorario(int cliente, int idDeptoSucursal)
        {
            return UnitOfWork.RepositoryCommon.GetCatalogoHorario(cliente, idDeptoSucursal);
        }

        public List<TipoHorarioDto> GetTipoHorario()
        {
            return UnitOfWork.RepositoryCommon.GetTipoHorario();
        }

        public List<GetNivelHorario> GetNivelHorario()
        {
            return UnitOfWork.RepositoryCommon.GetNivelHorario();
        }
        public List<GetServicioHorario> GetServicioHorario()
        {
            return UnitOfWork.RepositoryCommon.GetServicioHorario();
        }

        public List<GetTipoCHorario> GetTipoCHorario()
        {
            return UnitOfWork.RepositoryCommon.GetTipoCHorario();
        }

        public bool ActualizaCatHorario(ActualizaCatHorarioDto horario)
        {
            return UnitOfWork.RepositoryCommon.ActualizaCatHorario(horario);
        }

        public bool InsertCatHorario(InsertaCatHorarioDTO horario)
        {
            return UnitOfWork.RepositoryCommon.InsertCatHorario(horario);

        }
        
        public bool DeleteCatHorario(string horario)
        {
            return UnitOfWork.RepositoryCommon.DeleteCatHorario(horario);

        }
        
        public int SaveToken(TokenAdd token)
        {
            return UnitOfWork.RepositoryCommon.SaveToken(token);

        }

        public bool LiberaToken(TokenMod token)
        {
            return UnitOfWork.RepositoryCommon.LiberaToken(token);
        }

        public bool DeleteToken(TokenMod token)
        {
            return UnitOfWork.RepositoryCommon.DeleteToken(token);
        }

        public List<CatalogoTokenDto> GetCatalogoToken(string emplid)
        {
            return UnitOfWork.RepositoryCommon.GetCatalogoToken(emplid);
        }

        public List<EmpleadoPermiso> GetEmpleadosCPermisos()
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosCPermisos();
        }

        public List<EmpleadoSNPermiso> GetEmpleadosSNPermisos()
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosSNPermisos();
        }

        public List<MenuPermisosDto> GetMenusPermisos()
        {
            return UnitOfWork.RepositoryCommon.GetMenusPermisos();
        }

        public List<MenusEmpleado> GetMenusPermisosEmpleado(string numEmpleado)
        {
            return UnitOfWork.RepositoryCommon.GetMenusPermisosEmpleado(numEmpleado);
        }

        public bool InsertPermisosEmpleado(InsertPermisosEmpleadoReq permisos)
        {
            return UnitOfWork.RepositoryCommon.InsertPermisosEmpleado(permisos);
        }
        public void UpdatePermisosEmpleado(UpdatePermisoEmpleadoReq permisos)
        {
            UnitOfWork.RepositoryCommon.UpdatePermisosEmpleado(permisos);
        }

        public bool DeletePermisosEmpleado(string numEmpleado)
        {
            return UnitOfWork.RepositoryCommon.DeletePermisosEmpleado(numEmpleado);
        }
        public List<GetSeccionesEmpleadoRes> GetSeccionesEmpleado(string numEmpleado)
        {
            return UnitOfWork.RepositoryCommon.GetSeccionesEmpleado(numEmpleado);
        }
        public List<GetSucursalEmpleadoClientesRes> GetSucursalEmpleadoClientes(GetSucursalEmpleadoClientesReq empleado)
        {
            return UnitOfWork.RepositoryCommon.GetSucursalEmpleadoClientes(empleado);
        }


        public List<EmpleadosRes> GetEmpleados(EmpleadosReq empleado)
        {
            return UnitOfWork.RepositoryCommon.GetEmpleados(empleado);
        }
        public List<EmpleadosDetalleRes> GetEmpleadosDetalle(string empleado)
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosDetalle(empleado);
        }
        public List<EmpleadosCatalogo> GetEmpleadosCatalogos(string numEmpleado, string numEmpleadoSearch)
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosCatalogos(numEmpleado,numEmpleadoSearch);
        }

        public List<EmpleadosCatalogoTelefonos> GetEmpleadosCatalogoTelefonos(string telefono)
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosCatalogoTelefonos(telefono);
        }

        public List<EmpleadosCatalogoEstatus> GetEmpleadosCatalogoEstatus(string numEmpleado, string estatus)
        {
            return UnitOfWork.RepositoryCommon.GetEmpleadosCatalogoEstatus(numEmpleado,estatus);
        }

        public int UpdateEmpleadosCatalogo(UpdateEmpleadosCatalogo empleado)
        {
            return UnitOfWork.RepositoryCommon.UpdateEmpleadosCatalogo(empleado);
        }
        public void UpdateMasivoEmpleados(List<UpdateEmpleadosMasive> empleados)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            StringBuilder xmlBuilder = new StringBuilder();
            xmlBuilder.Append("<empleados>");

            foreach (var empleado in empleados)
            {
                xmlBuilder.Append("<empleado>");
                xmlBuilder.AppendFormat("<correo>{0}</correo>", empleado.correo.Trim());
                xmlBuilder.AppendFormat("<telefono>{0}</telefono>", empleado.telefono.Trim());
                xmlBuilder.AppendFormat("<whatsapp>{0}</whatsapp>", empleado.whatsapp.Trim());
                xmlBuilder.AppendFormat("<numempleado>{0}</numempleado>", empleado.numempleado);
                xmlBuilder.Append("</empleado>");
            }
 
            xmlBuilder.Append("</empleados>");
            string empleadosXML = xmlBuilder.ToString();
            
            UnitOfWork.RepositoryCommon.UpdateMasivoEmpleados(empleadosXML);
        }

        public List<DiasFestivosCatalogo> GetDiasFestivos()
        {
            return UnitOfWork.RepositoryCommon.GetDiasFestivos();
        }
        public bool AddDiaFestivo(DiasFestivosCatalogoReqAddDto fecha)
        {
            return UnitOfWork.RepositoryCommon.AddDiaFestivo(fecha);
        }
        public bool UpdateDiasFestivos(DiasFestivosCatalogoUpdate fecha)
        {
            return UnitOfWork.RepositoryCommon.UpdateDiasFestivos(fecha);
        }
        public bool DeleteDiasFestivos(int id)
        {
            return UnitOfWork.RepositoryCommon.DeleteDiasFestivos(id);
        }
        
        public List<GetHorariosAsignaRes> GetHorariosAsigna(string  cliente, string sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetHorariosAsigna(cliente, sucursal);
        }
        public List<GetListaAsignaRes> GetListaHorariosAsigna(GetListaAsignaReq asigna)
        {
            return UnitOfWork.RepositoryCommon.GetListaHorariosAsigna(asigna);
        }
        public List<GetListaAsignaRes> GetListaHorariosAsignaEdit(GetListaAsignaUpReq asigna)
        {
            return UnitOfWork.RepositoryCommon.GetListaHorariosAsignaEdit(asigna);
        }
        public int AddAsignacionTemp(AsignacionReq asigna)
        {
            return UnitOfWork.RepositoryCommon.AddAsignacionTemp(asigna);
        }
        public int UpdateAsignacionTemp(AsignacionReq asigna)
        {
            return UnitOfWork.RepositoryCommon.UpdateAsignacionTemp(asigna);
        }
        public int DeleteAsignacionTemp(AsignacionDelReq asigna)
        {
            return UnitOfWork.RepositoryCommon.DeleteAsignacionTemp(asigna);
        }
       
        
        
    }
}
