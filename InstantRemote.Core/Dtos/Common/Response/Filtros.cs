namespace InstantRemote.Core.Dtos.Common.Response
{

    public class GetResponsablesRespDto
    {
        public int id { get; set; }
        public string responsable { get; set; }
    }

    public class GetConstEnrolaRsp
    {
        public int empleados { get; set; }
        public string nombre { get; set; }
        public string site { get; set; }
        public string BUSINESS_UNIT { get; set; }
        public string seccion { get; set; }
        public string division { get; set; }
        public string fecha { get; set; }
        public string desc_site { get; set; }
        public string cliente { get; set; }
        public string con_check { get; set; }
    }
    
    public class GetDispositivosResp
    {
        public int idDeptoDispositivo { get; set; }
        public string nomDispositvo { get; set; }
        public string numSerie { get; set; }
        public string estadoConexion { get; set; }
        public string fechaUltimaConexion { get; set; }
        public string tipo { get; set; }
        public string longitud { get; set; }
        public string latitud { get; set; }
        public string nomCliente { get; set; }
        public string nomSucursal { get; set; }
        public int Empleados { get; set; }
        public int Huellas { get; set; }
        public int idTipoDispositivo { get; set; }
        public int planAuto { get; set; }
        public int deptId { get; set; }
    }
    
    public class GetDispositivoDetalleResp
    {
        public int badgenumber { get; set; }
        public string name { get; set; }
        public int enrolado { get; set; }
        public int cuantashuellas { get; set; }
    }

    public class GetCatZonaClientesRespDto
    {
        public int id { get; set; }
        public string cliente { get; set; }
    }
  
    public class GetWeekResp
    {
        public int idc { get; set; }
        public string calendario { get; set; }
    }
      public class GetYearResp
    {
        public int id { get; set; }
        public string year { get; set; }
    }
    
    

    public class GetSucursalesRespDto
    {
        public int id { get; set; }
        public string sucursal { get; set; }
    }
    public class UpdateSucursalMasive
    {
        public int idDeptoSucursal { get; set; }
        public string colonia { get; set; }
        public string numInt { get; set; }
        public string numExt { get; set; }
        public string cp { get; set; }
        public float longitud { get; set; }
        public float latitud { get; set; }
        public string error { get; set; }
        public string estado { get; set; }
        public string municipio { get; set; }
        public string calle { get; set; }
        public string idEmpleado { get; set; }
    }
    public class GetAllSucursalRes
    {
        public string idDeptoSucursal { get; set; }
        public string nomSucursal { get; set; }
        public int idCliente { get; set; }
        public string nomCliente { get; set; }
        public string calle { get; set; }
        public string numExt { get; set; }
        public string numInt { get; set; }
        public string colonia { get; set; }
        public string cp { get; set; }
        public string alcaldia_municipio { get; set; }
        public string estado { get; set; }
        public string longitud { get; set; }
        public string latitud { get; set; }
        public string fechaAlta { get; set; }
        public string seccion { get; set; }
        public string NumSiteNuevo { get; set; }
        public string NumSiteAnterior { get; set; }
        public string planAuto { get; set; }
        public string ZonaHoraria { get; set; }
        public string origenLlamado { get; set; }
        public string biometricos { get; set; }
        public string telefonos { get; set; }
        public string responsables { get; set; }
    }

    public class GetNivelHorario
    {
        public int id { get; set; }
        public string nivel { get; set; }
    }

    public class GetServicioHorario
    {
        public int id { get; set; }
        public string tipoServicio { get; set; }
    }

    public class GetTipoCHorario
    {
        public int id { get; set; }
        public string tipoComida { get; set; }
    }

    public class GetSitesRespDto
    {
        public int ID_SITE { get; set; }
        public string site { get; set; }
    }

    public class GetSitesClienteRespDto
    {
        public int ID_SITE { get; set; }
        public string nameSite { get; set; }
    }

    public class GetSitesSucursalRespDto
    {
        public int idSite { get; set; }
        public string nameSite { get; set; }
    }


    public class GetSeccionesRespDto
    {
        public int idSeccion { get; set; }
        public string seccion { get; set; }
    }

    public class GetServicioRespDto
    {
        public int idTipoSer { get; set; }
        public string SERVICIO { get; set; }
    }

    public class GetClienteCatalogoRespDto
    {
        public int idCliente { get; set; }
        public string cliente { get; set; }
        public string responsable { get; set; }
        public string fechaAlta { get; set; }
    }

    public class TipoHorarioDto
    {
        public int id { get; set; }
        public string tipoHorario { get; set; }
    }

    public class HorarioDTO
    {
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public int IdHorario { get; set; }
        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string Nombre { get; set; }
        public string PlanAuto { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string DiaDescanso { get; set; }
        public string Site { get; set; }
        public string DifeHorario { get; set; }
        public string DescripcionShort { get; set; }
        public int Tolerancia { get; set; }
        public string Tipo { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public string Jornada { get; set; }
        public int Caduca { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string TipoComida { get; set; }
        public string HoraEntradaComida { get; set; }
        public string HoraSalidaComida { get; set; }
        public int ComidaLibre { get; set; }
        public string HoraMinChecar { get; set; }
        public string HoraMaxChecar { get; set; }
        public string CierreChequeo { get; set; }
        public string Nivel { get; set; }
        public string NotEdit { get; set; }
        public string Asignacion { get; set; }
        public string IdTipoSer { get; set; }
    }

    public class CatalogoHorarioFiltroDto
    {
        public int idDeptoSucursal { get; set; }
        public string nomSucursal { get; set; }
        public string nomCliente { get; set; }
        public string domicilio { get; set; }
        public DateTime fechaAlta { get; set; }
        public string NumSite { get; set; }
        public int planAuto { get; set; }
        public string notas { get; set; }
        public string zonaHoraria { get; set; }
        public string origenLlamado { get; set; }
        public string biometricos { get; set; }
        public string telefonos { get; set; }
        public string Horario { get; set; }
        public int responsable { get; set; }
        public string calle { get; set; }
        public int colonia { get; set; }
        public int numExt { get; set; }
        public int id_CP { get; set; }
        public int idCliente { get; set; }
        public double longitud { get; set; }
        public double latitud { get; set; }
        public string numInt { get; set; }
        public int alBio { get; set; }
        public int alInc { get; set; }
        public int alPlan { get; set; }
        public int alTol { get; set; }
        public int alPlanI { get; set; }
        public string Site_hijo1 { get; set; }
        public string Site_hijo2 { get; set; }
        public string Site_hijo3 { get; set; }
        public int idSeccion { get; set; }
        public int idZonaHoraria { get; set; }
        public string idTelefonos { get; set; }
        public string idSites { get; set; }
        public int id_edo { get; set; }
        public int id_mun { get; set; }
        public int idOLL { get; set; }
        public int id_col { get; set; }
    }

    public class CatalogoTokenDto
    {
        public string numEmpleado { get; set; }
        public string nombre { get; set; }
        public string status { get; set; }
        public string tokenId { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }

    }

    public class TokenAdd : TokenMod
    {
        public string tipoToken { get; set; }
    }

    public class TokenMod
    {
        public string emplid { get; set; }
        public string numEmpleado { get; set; }
    }

    public class ActualizaCatHorarioDto
    {
        public int idHorario { get; set; }
        public string nomHorario { get; set; }
        public string tipoHorario { get; set; }
        public int idCliente { get; set; }
        public int idSucursal { get; set; }
        public string plantillaAuto { get; set; }
        public string tolerancia { get; set; }
        public string jornada { get; set; }
        public string diaDescanso { get; set; }
        public string difHorario { get; set; }
        public int nivel { get; set; }
        public string tipoServicio { get; set; }
        public string site { get; set; }

        public string lunes { get; set; }
        public string martes { get; set; }
        public string miercoles { get; set; }
        public string jueves { get; set; }
        public string viernes { get; set; }
        public string sabado { get; set; }
        public string domingo { get; set; }

        public string HraEntrada { get; set; }
        public string HraSalida { get; set; }
        public string HraMin { get; set; }
        public string HraMax { get; set; }
        public string HraCierre { get; set; }

        public string TipoComida { get; set; }
        public string TiempoComida { get; set; }
        public string EntradaComida { get; set; }
        public string SalidaComida { get; set; }
    }
    
    public class InsertaCatHorarioDTO
    {
        public string HE { get; set; } = "0";
        public string HS { get; set; } = "0";
        public string Tolerancia { get; set; } = "0";
        public string Tipo { get; set; } = "0";
        public string Lunes { get; set; } = "0";
        public string Martes { get; set; } = "0";
        public string Miercoles { get; set; } = "0";
        public string Jueves { get; set; } = "0";
        public string Viernes { get; set; } = "0";
        public string Sabado { get; set; } = "0";
        public string Domingo { get; set; } = "0";
        public string Jornada { get; set; } = "0";
        public string TipoComida { get; set; }
        public string HoraEntradaComida { get; set; }
        public string HoraSalidaComida { get; set; }
        public string ComidaLibre { get; set; }
        public string HMinCheck { get; set; }
        public string HMaxCheck { get; set; }
        public string CierreChequeo { get; set; }
        public string Nombre { get; set; }
        public int IdCliente { get; set; }
        public int IdSucursal { get; set; }
        public string PlanAuto { get; set; }
        public string DiaDescanso { get; set; }
        public string DifeHorario { get; set; }
        public int Nivel { get; set; }
        public string Site { get; set; }
        public string IdTipoSer { get; set; }
    }

    public class MenuPermisosDto
    {
        public int idTipoMenu { get; set; }
        public string descripcion { get; set; }
        public string path { get; set; }
        public string tipo { get; set; }
        public string baja_logica { get; set; }
    }
    
    public class EmpleadoSNPermiso
    {
        public long numEmpleado { get; set; }
        public string nomCompleto { get; set; }
        public string fechaAlta { get; set; }
        public string numGrupos { get; set; }
    }
    public class MenusEmpleado
    {
        public string menu { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
    }
    public class InsertPermisosEmpleadoReq
    {
        public string empleados { get; set; }
        public string tipoPermiso { get; set; }
        public string secciones { get; set; }
        public string todoSeccion { get; set; }
        public string clientes { get; set; }
        public string sucursales { get; set; }
        public string todoSucursal { get; set; }
        public int dashboard { get; set; }
        public int dispositivos { get; set; }
        public int empleado { get; set; }
        public int mapa { get; set; }
        public int libroAsistencia { get; set; }
        public int acumuladoAsistencia { get; set; }
        public int reportAsistencia { get; set; }
        public int asistenciaEstandar { get; set; }
        public int ausentismos { get; set; }
        public int repClientes { get; set; }
        public int EdoEnrolamiento { get; set; }
        public int fichaAsistencia { get; set; }
        public int HoraExtra { get; set; }
        public int huerfanos { get; set; }
        public int logAsistencia { get; set; }
        public int RecordAsis { get; set; }
        public int RecordAsisAnual { get; set; }
        public int repApp { get; set; }
        public int repRetardo { get; set; }
        public int asignaEmpleado { get; set; }
        public int catCliente { get; set; }
        public int diasFestivos { get; set; }
        public int empleadosCat { get; set; }
        public int horario { get; set; }
        public int permisos { get; set; }
        public int sucursal { get; set; }
        public int token { get; set; }
        public int temperatura { get; set; }
        public int ausenOmision { get; set; }
        public int asignacionTemporal { get; set; }
        public int constantes { get; set; }
        public int autorizaHrasExtras { get; set; }
        public int solicitaHrasExtras { get; set; }
        public int bloqueoManual { get; set; }
        public int matrizAprobacion { get; set; }
        public int rephrasExtrasAuto { get; set; }
        public int rephrasExtrasNoProcede { get; set; }
        public int capturaManual { get; set; }
        public int capturaMasiva { get; set; }
        public int actualizacionEmpMasiva { get; set; }

    }
    public class UpdatePermisoEmpleadoReq
    {
        public string numEmpleado { get; set; }
        public string tipoPermiso { get; set; }
        public string oldPermiso { get; set; }
        public string secciones { get; set; }
        public string todoSeccion { get; set; }
        public string clientes { get; set; }
        public string sucursales { get; set; }
        public string todoSucursal { get; set; }
        public int dashboard { get; set; }
        public int dispositivos { get; set; }
        public int empleado { get; set; }
        public int mapa { get; set; }
        public int libroAsistencia { get; set; }
        public int acumuladoAsistencia { get; set; }
        public int reportAsistencia { get; set; }
        public int asistenciaEstandar { get; set; }
        public int ausentismos { get; set; }
        public int repClientes { get; set; }
        public int EdoEnrolamiento { get; set; }
        public int fichaAsistencia { get; set; }
        public int HoraExtra { get; set; }
        public int huerfanos { get; set; }
        public int logAsistencia { get; set; }
        public int RecordAsis { get; set; }
        public int RecordAsisAnual { get; set; }
        public int repApp { get; set; }
        public int repRetardo { get; set; }
        public int asignaEmpleado { get; set; }
        public int cliente { get; set; }
        public int diasFestivos { get; set; }
        public int empleadosCat { get; set; }
        public int horario { get; set; }
        public int permisos { get; set; }
        public int sucursal { get; set; }
        public string eml { get; set; }
        public int token { get; set; }
        public int temperatura { get; set; }
        public int repausenOmision { get; set; }
        public int asignacionTemporal { get; set; }
        public int constantes { get; set; }
        public int autorizaHrasExtras { get; set; }
        public int solicitaHrasExtras { get; set; }
        public int bloqueoManualEdit { get; set; }
        public int matrizAprobacionEdit { get; set; }
        public int repcapturaManual { get; set; }
        public int repHrasExtrasAuto { get; set; }
        public int repHrasExtrasNoProce { get; set; }
        public int capturaMasiva { get; set; }
        public int actualizacionEmpMasiva { get; set; }
    }




    public class EmpleadoPermiso
    {
        public long idDRM { get; set; }
        public string numEmpleado { get; set; }
        public string nombre { get; set; }
        public string idCliente { get; set; }
        public string nomClientes { get; set; }
        public string idSucursal { get; set; }
        public string nomSucursal { get; set; }
        public bool dashboard { get; set; }
        public bool mapa { get; set; }
        public bool dispositivos { get; set; }
        public bool empleados { get; set; }
        public bool libroAsistencia { get; set; }
        public bool autorizaHrasExtras { get; set; }
        public bool solicitaHrasExtras { get; set; }
        public bool catalogosAdmin { get; set; }
        public bool reportesAdmin { get; set; }
        public bool bloqueoManual { get; set; }
    }

    public class EmpleadosRes
    {
        public long numEmpleado { get; set; }
        public string nomCompleto { get; set; }
        public string puesto { get; set; }
        public string seccion { get; set; }
        public string site { get; set; }
        public string SERVICIO { get; set; }
        public string desDepto { get; set; }
        public int totalAsignado { get; set; }
        public string status { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
    }

    public class EmpleadosReq
    {
        public string emplid { get; set; }
        public string seccionVarchar { get; set; }
        public string siteVarchar { get; set; }
        public string servicioVarchar { get; set; }
        public string empEspecifico { get; set; }
        public string cliente { get; set; }
        public string sucursal { get; set; }
    }
    
    public class EmpleadosDetalleRes
    {
        public string Cliente { get; set; }
        public string Alias { get; set; }
        public string SN { get; set; }
        public string horaEntrada { get; set; }
        public string horaSalida { get; set; }
        public string nombre { get; set; }
    }
    
    
    
    public class EmpleadosCatalogo
    {
        public long numEmpleado { get; set; }
        public string nombre { get; set; }
        public string puesto { get; set; }
        public string seccion { get; set; }
        public string site { get; set; }
        public int shift { get; set; }
        public string desDepto { get; set; }
        public string SERVICIO { get; set; }
        public string status { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string biometrico { get; set; }
        public int TOTAL { get; set; }
        public string telefonia { get; set; }
        public string APP { get; set; } 
        public bool whatsapp { get; set; } 
    }
    public class EmpleadosCatalogoTelefonos
    {
        public int numEmpleado { get; set; }
        public string status { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
    public class EmpleadosCatalogoEstatus
    {
        public int numEmpleado { get; set; }
        public string nombre { get; set; }
        public string puesto { get; set; }
        public string seccion { get; set; }
        public string site { get; set; }
        public int shift { get; set; }
        public string desDepto { get; set; }
        public string SERVICIO { get; set; }
        public string status { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string biometrico { get; set; }
        public string Total { get; set; }
        public string telefonia { get; set; }
        public string APP { get; set; }
    }
    public class UpdateEmpleadosCatalogo
    {
        public int numEmpleado { get; set; } 
        public int asisWhats { get; set; } 
        public string correo { get; set; } 
        public string telefono { get; set; } 

    } 
    public class UpdateEmpleadosMasive
    {
        public int numempleado { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string whatsapp { get; set; } 
    }
    
    public class DiasFestivosCatalogo : DiasFestivosCatalogoReqAddDto
    {
        public int idDiaFes { get; set; }
    }
    public class DiasFestivosCatalogoUpdate : DiasFestivosCatalogoReqAddDto
    {
        public int idDia { get; set; }
    }
    
    public class DiasFestivosCatalogoReqAddDto
    {
        public string fecha { get; set; }
        public string Descripcion { get; set; }
    }
    public class GetSeccionesEmpleadoRes
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int valor { get; set; }
    }
    public class GetSucursalEmpleadoClientesReq
    {
        public string emplid { get; set; }
        public string cliente { get; set; }
        public string sucursales { get; set; }
    }
    public class GetSucursalEmpleadoClientesRes
    {
        public int id { get; set; }
        public string site { get; set; }
        public string sucursal { get; set; }
        public string cliente { get; set; }
        public int valor { get; set; }
    }

    public class GetHorariosAsignaRes
    {
        public int idHorario { get; set; }
        public string horario { get; set; }
        public string site { get; set; }
    }
    public class GetListaAsignaReq:GetListaAsignaUpReq
    {
        public string empleado { get; set; }
    }
    public class GetListaAsignaUpReq
    {
        public int cliente { get; set; }
        public int sucursal { get; set; }
        public string horario { get; set; }
        public string site { get; set; }
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
    }
    public class GetListaAsignaRes
    {
        public int numEmpleado { get; set; }
        public string nomCompleto { get; set; }
        public string fechaAlta { get; set; }
        public string numero { get; set; }
    }
    public class AsignacionReq
    {
        public string numEmpleado { get; set; }
        public string idCliente { get; set; }
        public string idSucursal { get; set; }
        public string idHorario { get; set; }
        public string site { get; set; }
        public string fechaIn { get; set; }
        public string fechaFin { get; set; }
    }
    public class AsignacionDelReq
    {
        public string numEmpleado { get; set; }
        public string idCliente { get; set; }
        public string idSucursal { get; set; }
        public string idHorario { get; set; }
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
    }
    
    public class FiltroCommon
    {
        public string fechaini { get; set; }
        public string fechafin { get; set; }
    }
    public class FiltroHuerfanos
    {
        public string fechaHu { get; set; }
        public string fechaHufin { get; set; }
        public string empleado { get; set; }
        public string empleadoEspecifico { get; set; }
        public string seccionVarchar { get; set; }
        public string siteVarchar { get; set; }
        public string servicioVarchar { get; set; }
        public string idSucursal { get; set; }
        public string idCliente { get; set; }

    }
    public class FiltroEdoEnrola
    {
        public string empleado { get; set; }
        public string cliente { get; set; }
        public string idDeptoSucursal { get; set; }
        public string empleadoEspecifico { get; set; }
        public string seccionVarchar { get; set; }
        public string siteVarchar { get; set; }
        public string servicioVarchar { get; set; }
    }
    
    public class FiltrosReq :FiltroCommon
    {
       
        public string cliente { get; set; }
        public string idSucursal { get; set; }
        public string emplid { get; set; }
        public string empleadoEspecifico { get; set; }
        public string seccionVarchar { get; set; }
        public string siteVarchar { get; set; }
        public string servicioVarchar { get; set; }
    }
    public class FiltrosRepReq: FiltroCommon
    {
     
        public string idCliente { get; set; }
        public string idSucursal { get; set; }
       public string seccionVarchar { get; set; }
        public string siteVarchar { get; set; }
        public string empleadoEspecifico { get; set; }
        public string empleado { get; set; }
        public string servicioVarchar { get; set; }
    }
    
    public class LogAsistenciaResp
    {
        public int badgenumber { get; set; }
        public string apellidos { get; set; }
        public string puesto { get; set; }
        public string seccion { get; set; }
        public string site { get; set; }
        public string SERVICIO { get; set; }
        public string grupo_pago { get; set; }
        public string nomCliente { get; set; }
        public string nomSucursal { get; set; }
        public string SN { get; set; }
        public string fecha_origen { get; set; }
        public TimeSpan hora_origen { get; set; }
        public string id_tipo_logeo { get; set; }
        public string servi { get; set; }
        public string OrigEmpleado { get; set; }
        public string suMarcacion { get; set; }
    }

    public class RetardosResp
    {
        public int numEmpleado { get; set; }
        public string nombre { get; set; }
        public string puesto { get; set; }
        public string nomCliente { get; set; }
        public string seccion { get; set; }
        public string site { get; set; }
        public string DeptName { get; set; }
        public string SN { get; set; }
        public TimeSpan horaEntrada { get; set; }
        public string servi { get; set; }
        public string SERVICIO { get; set; }
        public string tolerancia { get; set; }
        public string fecha { get; set; }
        public TimeSpan chequeo { get; set; }
        public TimeSpan horatolerancia { get; set; }
        public string MINUTOS { get; set; }
        
    }
 public class HuerfanosResp
    {
      
        public string numeroEmpleado {get; set;}
        public string nombre {get; set;}
        public string puesto {get; set;}
        public string fechaAlta {get; set;}
        public string fechaBaja {get; set;}
        public string seccion {get; set;}
        public string PosicionOrigen {get; set;}
        public string site {get; set;}
        public string desDepto {get; set;}
        public string SERVICIO {get; set;}
        public string shift {get; set;}
        public string telefono {get; set;}
        public string FECHA {get; set;}
        public string HORA {get; set;}
        public string estado {get; set;}
        public string mensaje {get; set;}
    }

    public class GetReportesClientes
    {
        public int idDeptoSucursal {get; set;}
        public string nomSucursal {get; set;}
        public string nomCliente {get; set;}
        public string responsable {get; set;}
        public string calle {get; set;}
        public string colonia {get; set;}
        public string numInt {get; set;}
        public string numExt {get; set;}
        public string CP {get; set;}
        public string NumSite {get; set;}
        public string SN {get; set;}
        public string zonHoraria {get; set;}

    }

}