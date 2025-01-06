using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using AutoMapper;
using Dapper;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryCommon : BaseRepository, IRepositoryCommon
    {
        public RepositoryCommon(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {

        }

        public void InsertBitacoraInstantRemote(BitacoraRequestDto bitacora)
        {
            var query = "INSERT INTO tblBitacoraInstanRemote values ('" 
                                + bitacora.Usuario + "' ,'" 
                                + bitacora.Accion + "','" 
                                + bitacora.Descripcion + "','"
                                + bitacora.Pantalla + "',GETDATE(),'')"; 
            Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault();
        }


        public List<GetResponsablesRespDto> GetResponsables( )
        {
            var query = "select distinct convert(int,EMPLID1) as id ,convert(varchar(50),convert(int,EMPLID1)) + '-' + NAME1 as responsable from tblJerarquia order by 1 ";
            return Connection.Query<GetResponsablesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        public List<TelefonosSucursalN> GetTelefonos (int idSucursal, string empleado)
        {
            var response = Connection.Query<TelefonosSucursalN>(StoreProcedure.sp_GetTelefonosRestriccion, new
            {
                @idSucursal = idSucursal,
                @empleado = empleado
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        

        #region sucursales
        //listaSucursalesCombo / listaSucursalesComboBJ admin

        public List<GetSucursalesRespDto> GetSucursales(string parameter)
        {
            var query = "SELECT idDeptoSucursal as id ,nomSucursal as sucursal FROM  catDeptoSucursal WITH (nolock) ";
            if (parameter != null)
                query += "WHERE idCliente = '" + parameter +"'";

            query += "ORDER BY 1";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        //dividir el SP listaSucursalesComboBJ si es @clie = '000' seccion
        public List<GetSucursalesRespDto> GetSucursalesSeccion(int emplid, string cliente)
        {
            var query = "select distinct  idDeptoSucursal as id ,nomSucursal as sucursal " +
                        "from tbl_empleado_seccion a join catSeccion b on a.seccion = b.descripcion " +
                        "join catDeptoSucursal c on b.idSeccion =c.idSeccion " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid =  " + emplid +
                        "and d.idZonaCliente = '" + cliente +"'";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaSucursalesComboBJ si es @clie = '000000' site
        public List<GetSucursalesRespDto> GetSucursalesSite(int emplid, string cliente)
        {
            var query = "select  c.idDeptoSucursal as id,c.nomSucursal as sucursal  from tbl_empleado_site a " +
                        "join tbl_sucursalSite b on a.site = b.nameSite " +
                        "join catDeptoSucursal c on b.idSucursal =c.idDeptoSucursal " +
                        "where emplid = "+  emplid  +
                        "and c.idCliente = '" + cliente + "'";

            return Connection.Query<GetSucursalesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaSucursalesComboBJ si es jerarquia u otro
        public List<GetSucursalesRespDto> GetSucursalesJerarquiaOtro(int emplid, string cliente)
        {
            var response = Connection.Query<GetSucursalesRespDto>(StoreProcedure.listaSucursalesComboJerarquiaOtros, new
            {
                @emplid = emplid,
                @cliente = cliente
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetSucursalesRespDto> GetSucursalSecciones(int emplid, int otro)
        {
            var response = Connection.Query<GetSucursalesRespDto>(StoreProcedure.sp_GetSucursalSeccion, new
            {
                @emplid = emplid,
                @otro2 = otro

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<CatalogoSucursaRespDto> GetSucursalCatalogo(int cliente, int sucursal)
        {
            var response = Connection.Query<CatalogoSucursaRespDto>(StoreProcedure.sp_GetCatalogoSucursal, new
            {
                @cliente = cliente,
                @sucursal = sucursal

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public List<DetalleTelefonosRespDto> GetTelefonosDetalles(int sucursal)
        {

            var query = "select idTel,numTel from tbl_sucursalTel where idSucursal = @idSucursal";

            return Connection.Query<DetalleTelefonosRespDto>(query, new { @idSucursal = sucursal }).ToList();
        }

        public List<DetalleBiometricosRespDto> GetBiometricosDetalles(int sucursal)
        {

            var query = "select idTel,numTel from tbl_sucursalTel where idSucursal = @idSucursal";

            return Connection.Query<DetalleBiometricosRespDto>(query, new { @idSucursal = sucursal }).ToList();
        }
        public List<DetalleSitesRespDto> GetSitesDetalles(int sucursal)
        {

            var query = "select idSite,nameSite from tbl_sucursalSite where idSucursal = @idSucursal";

            return Connection.Query<DetalleSitesRespDto>(query, new { @idSucursal = sucursal }).ToList();
        }
        public List<DetalleHorariosRespDto> GetHorariosDetalles(int sucursal)
        {

            var query = "select idSite,nameSite from tbl_sucursalSite where idSucursal = @idSucursal";

            return Connection.Query<DetalleHorariosRespDto>(query, new { @idSucursal = sucursal }).ToList();
        }
        
        public List<DetalleResponsableRespDto> GetResponsablesDetalles(string Parametros)
        {

            var response = Connection.Query<DetalleResponsableRespDto>(StoreProcedure.sp_GetResponsablesDetalle, new
            {
                @Parametros = Parametros

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public List<SitesSucursalN> GetSitesSucursalN(int idSucursal)
        {
            var response = Connection.Query<SitesSucursalN>(StoreProcedure.sp_GetSites, new
            {
                @idSucursal = idSucursal

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<BioSucursalN> GetBioSucursalN(int idSucursal)
        {
            var response = Connection.Query<BioSucursalN>(StoreProcedure.sp_GetBiometricos, new
            {
                @idSucursal = idSucursal

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public List<GetCandados> GetCandado()
        {
            var query = "select idOLL ,descripcionOLL  from  catOrigenLlamado with (nolock)";
            return Connection.Query<GetCandados>(query).ToList();
        }
        
        public bool InsertTelefonoSucursal(NewTelefonoSucursal telefono)
        {
            var rowsAffected = Connection.Execute(StoreProcedure.IR_V2_SP_InsertaTelefono, telefono, commandType: CommandType.StoredProcedure);
            return rowsAffected > 0;
        }
        public bool InsertSucursal(SucursalInsertDTO sucursal)
        {
            var rowsAffected = Connection.Execute(StoreProcedure.IR_V2_SP_Add_Sucursal, sucursal, commandType: CommandType.StoredProcedure);
            return rowsAffected > 0;
        }
        public bool UpdateSucursal(SucursaUpdateDto sucursal)
        {
            var rowsAffected = Connection.Execute(StoreProcedure.IR_V2_SP_Update_Sucursal, sucursal, commandType: CommandType.StoredProcedure);
            return rowsAffected > 0;
        }
        public bool DeleteSucursal(int idSucursal)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_RP_Elimina_Sucursal, new
            {
                @nomCliente = idSucursal,

            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public List<TelefonosSucursalN> GetTelefonosbyId(string tel)
        {
            var telList = tel.Split(',').Select(int.Parse).ToList();
            var query = "SELECT * FROM dbo.catTelefono WHERE idTel IN @telList";
            return Connection.Query<TelefonosSucursalN>(query, new { telList }).ToList();
        }

        
        
        #endregion

        #region Clientes
        //catzonaclientes admin / tambien se uso para el dashcombo
        public List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter)
        {
            var query = "SELECT idZonaCliente as id ,nomCliente as cliente FROM  catZonaCliente WITH (nolock)";
            if (parameter != null)
                query += "WHERE idZonaCliente in (" + parameter + ")";

            query += "ORDER BY idZonaCliente";

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaClientesComboBJ si es @clie = '000' seccion
        public List<GetCatZonaClientesRespDto> GetClienteSeccion(int emplid)
        {
            var query = "select distinct d.idZonaCliente as id , d.nomCliente as cliente " +
                        "from tbl_empleado_seccion a " +
                        "join catSeccion b on a.seccion = b.descripcion " +
                        "join catDeptoSucursal c on b.idSeccion =c.idSeccion " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid = " + emplid;

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        //dividir el SP listaClientesComboBJ si es @clie = '000000' site
        public List<GetCatZonaClientesRespDto> GetClienteSite(int emplid)
        {
            var query = "select distinct d.idZonaCliente as id , d.nomCliente as cliente " +
                        "from tbl_empleado_site a " +
                        "join tbl_sucursalSite b on a.site = b.nameSite " +
                        "join catDeptoSucursal c on b.idSucursal =c.idDeptoSucursal " +
                        "join catZonaCliente d on c.idCliente = d.idZonaCliente " +
                        "where emplid = " + emplid;

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }
        //dividir el SP listaClientesComboBJ si es jerarquia u otro
        public List<GetCatZonaClientesRespDto> GetClienteJerarquiaOtro(int emplid)
        {
            var response = Connection.Query<GetCatZonaClientesRespDto>(StoreProcedure.listaClientesComboJerarquiaOtros, new
            {
                @emplid = emplid
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetClienteCatalogoRespDto> GetCatalogoCliente()
        {
            var response = Connection.Query<GetClienteCatalogoRespDto>(StoreProcedure.sp_GetCatalogoCliente, new
            {
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetClienteCatalogoRespDto> GetClienteSecciones(int emplid, int otro)
        {
            var response = Connection.Query<GetClienteCatalogoRespDto>(StoreProcedure.sp_GetClienteSeccion, new
            {
                @emplid = emplid,
                @otro2 = otro

            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public bool InsertCliente(CatalogoClienteReqDto dataCliente)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_InsertaCliente, new
            {
                @nomCliente = dataCliente.cliente,
                @reponsable = dataCliente.responsable,
                @fechaAlta = DateTime.Now

            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        public bool UpdateCliente(CatalogoClientUpdateeReqDto dataCliente)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_ActualizaCliente, new
            {
                @nomCliente = dataCliente.cliente,
                @reponsable = dataCliente.responsable,
                @cliente = dataCliente.id

            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public bool DeleteCliente(int idCliente)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_EliminaCliente, new
            {
                @cliente = idCliente

            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }

        #endregion

        #region Seccion

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetSeccionesRespDto> GetSecciones(int emplid, string otro)
        {
            var response = Connection.Query<GetSeccionesRespDto>(StoreProcedure.sp_GetSecciones, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public List<GetSeccionesRespDto> GetSeccion()
        {
            var query = "select idSeccion,descripcion as seccion from  catSeccion with (nolock)";

            return Connection.Query<GetSeccionesRespDto>(query, commandType: CommandType.Text).ToList();
        }

        public List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int otro)
        {
            var response = Connection.Query<GetSeccionesRespDto>(StoreProcedure.sp_GetSeccionesSucursal, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        #endregion

        #region Site

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetSitesRespDto> GetSites(int emplid, string otro)
        {
            var response = Connection.Query<GetSitesRespDto>(StoreProcedure.SP_GetSitesV2, new
            {
                @emplid = emplid,
                @otro = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetSitesRespDto> GetSitesCliente(int emplid, string otro)
        {
            var response = Connection.Query<GetSitesClienteRespDto>(StoreProcedure.sp_GetSitesCliente, new
            {
                @emplid = emplid,
                @cliente = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            var result = mapper.Map<List<GetSitesRespDto>>(response);

            return result;
        }

        public List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal)
        {
            var response = Connection.Query<GetSitesSucursalRespDto>(StoreProcedure.sp_GetSitesSucursal, new
            {
                @emplid = emplid,
                @sucursal = sucursal
            }, commandType: CommandType.StoredProcedure).ToList();
            var result = mapper.Map<List<GetSitesRespDto>>(response);

            return result;
        }
        #endregion

        #region Servicio

        //TODO SEPARAR sp PARA QUE SEA MÁS DINAMICO
        public List<GetServicioRespDto> GetServicio(int emplid, string otro)
        {
            var response = Connection.Query<GetServicioRespDto>(StoreProcedure.sp_GetTipoServicioV2, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetServicioRespDto> GetServicioSucursal(int emplid, int otro)
        {
            var response = Connection.Query<GetServicioRespDto>(StoreProcedure.sp_GetTipoServicioSucursal, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetServicioRespDto> GetServicioSeccion(int emplid, int otro)
        {
            var response = Connection.Query<GetServicioRespDto>(StoreProcedure.sp_GetTipoServicioSeccion, new
            {
                @emplid = emplid,
                @otro2 = otro
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        #endregion

        #region Horarios
       
        public List<HorarioDTO> GetCatalogoHorario(int cliente, int idDeptoSucursal)
        {
            var response = Connection.Query<HorarioDTO>(StoreProcedure.IR_V2_SP_GetCatalogoHorario, new
            {
                @Cliente = cliente,
                @idDeptoSucursal = idDeptoSucursal,
                @siteVarchar= "",
                @servicioVarchar = ""
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public bool ActualizaCatHorario (ActualizaCatHorarioDto horario)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_SP_ActualizaCatHorario,
           horario, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public bool InsertCatHorario (InsertaCatHorarioDTO horario)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_SP_InsertaCatHorario,
           horario, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        
        public bool DeleteCatHorario (string idHorario)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_SP_Elimina_Horario,
                new
                {
                    @idHorario = idHorario
                }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public List<TipoHorarioDto> GetTipoHorario()
        {
            var query = "select id ,tipoHorario  from  catTipoHorarios with (nolock) where tipoHorario not in ('Normal') order by id";
            return Connection.Query<TipoHorarioDto>(query, commandType: CommandType.Text).ToList();
        }
        public List<GetNivelHorario> GetNivelHorario()
        {
            var query = "SELECT idNivel as id, Descripcion as nivel FROM catNivel with (nolock) order by idNivel";
            return Connection.Query<GetNivelHorario>(query, commandType: CommandType.Text).ToList();
        }
        public List<GetServicioHorario> GetServicioHorario()
        {
            var query = "SELECT idTipoSer as id, Descripcion_long as tipoServicio FROM catTipoServicio with (nolock) order by idTipoSer";
            return Connection.Query<GetServicioHorario>(query, commandType: CommandType.Text).ToList();
        }
        public List<GetTipoCHorario> GetTipoCHorario()
        {
            var query = "select id ,descripcion as tipoComida  from  catTipoComida with (nolock) order by id";
            return Connection.Query<GetTipoCHorario>(query, commandType: CommandType.Text).ToList();
        }
        #endregion
        
        #region Token
        public List<CatalogoTokenDto> GetCatalogoToken(string emplid)
        {
            var response = Connection.Query<CatalogoTokenDto>(StoreProcedure.IR_V2_SP_GET_Tokens, new
            {
                @numempleado = emplid,
                
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public bool DeleteToken(TokenMod token)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_SP_DELETE_Token, new
            {
                @numEmpleado = token.numEmpleado,
                @numEmpleadoEncargado = token.emplid
                
            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public bool LiberaToken(TokenMod token)
        {
            var response = Connection.Query<bool>(StoreProcedure.IR_V2_SP_GET_LiberaToken, new
            {
                @numEmpleado = token.numEmpleado,
                @numEmpleadoEncargado = token.emplid
                
            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        
        public int SaveToken(TokenAdd token)
        {
            var response = Connection.Query<int>(StoreProcedure.IR_V2_SP_ADD_Token, new
            {
                @numEmpleado = token.numEmpleado,
                @numEmpleadoEncargado = token.emplid,
                @tipoToken = token.tipoToken
                
            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        #endregion
        
        #region Permisos
        public List<EmpleadoPermiso> GetEmpleadosCPermisos()
        {
            var response = Connection.Query<EmpleadoPermiso>(StoreProcedure.sp_GetEmpleadosTipoPermiso_V2, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        
        public List<EmpleadoSNPermiso> GetEmpleadosSNPermisos()
        {
            var response = Connection.Query<EmpleadoSNPermiso>(StoreProcedure.listaEmpleadosParaPermisos, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<MenuPermisosDto> GetMenusPermisos()
        {
            var query = "SELECT * FROM catTipoMenu WHERE baja_logica = 0";
            return Connection.Query<MenuPermisosDto>(query, commandType: CommandType.Text).ToList();
        }
        public List<MenusEmpleado> GetMenusPermisosEmpleado(string numEmpleado)
        {
            var response = Connection.Query<MenusEmpleado>(StoreProcedure.sp_GetConfiguracionRepCatEmpleado_v2, new{@numEmpleado= numEmpleado}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public bool InsertPermisosEmpleado(InsertPermisosEmpleadoReq permisos)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_InsertPermiso_v2,permisos , commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public bool UpdatePermisosEmpleado(UpdatePermisoEmpleadoReq permisos)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_UpdatePermiso_v2, permisos , commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public bool DeletePermisosEmpleado(string numEmpleado)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_EliminaPermiso, new { @numEmpleado =numEmpleado} , commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        
        }

        #endregion

        #region empleados
        public List<EmpleadosCatalogo> GetEmpleadosCatalogos(string numEmpleado, string numEmpleadoSearch)
        {
            var response = Connection.Query<EmpleadosCatalogo>(StoreProcedure.IR_V2_SP_GetCatEmpleadosById, new
            {
                @numEmpleado = numEmpleado,
                @numEmpleadoSearch = numEmpleadoSearch
                
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<EmpleadosCatalogoTelefonos> GetEmpleadosCatalogoTelefonos(string telefono)
        {
            var response = Connection.Query<EmpleadosCatalogoTelefonos>(StoreProcedure.IR_V2_SP_Get_EmpleadoByTelefono, new
            {
                @telefono = telefono
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<EmpleadosCatalogoEstatus> GetEmpleadosCatalogoEstatus(string numEmpleado, string estatus)
        {
            var response = Connection.Query<EmpleadosCatalogoEstatus>(StoreProcedure.IR_V2_SP_GetCatEmpleadosEstatus, new
            {
                @estatus  = estatus ,
                @numEmpleado = numEmpleado
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public int UpdateEmpleadosCatalogo(UpdateEmpleadosCatalogo empleado)
        {
            var response = Connection.Query<int>(StoreProcedure.IR_V2_SP_ActualizaCatEmpleado, empleado, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public void UpdateMasivoEmpleados(string empleadosXML)
        {
            Connection.Query(StoreProcedure.sp_updateMasivoEmpleadosXML, empleadosXML, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
        #endregion

        #region Dias Festivos

        public bool UpdateDiasFestivos(DiasFestivosCatalogoUpdate fecha)
        {
            var query = "UPDATE [dbo].catDiasFestivos SET Descripcion = @Descripcion ,fecha = @fecha WHERE idDiaFes = @idDia";
            var filasAfectadas = Connection.Execute(query, fecha, commandType: CommandType.Text);
            return filasAfectadas > 0;
        
        }
        public bool DeleteDiasFestivos(int id)
        {
            var query = "DELETE FROM catDiasFestivos WHERE idDiaFes = "+id;
            var filasAfectadas = Connection.Execute(query, commandType: CommandType.Text);
            return filasAfectadas > 0;
        
        }
        
        public List<DiasFestivosCatalogo> GetDiasFestivos()
        {
            var query = "SELECT idDiaFes, fecha, Descripcion FROM catDiasFestivos order by fecha asc";
            return Connection.Query<DiasFestivosCatalogo>(query, commandType: CommandType.Text).ToList();
        }
        public bool AddDiaFestivo(DiasFestivosCatalogoReqAddDto fecha)
        {
            var response = Connection.Query<bool>(StoreProcedure.sp_InsertaDiaFestivo, fecha, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        #endregion

    }
}
