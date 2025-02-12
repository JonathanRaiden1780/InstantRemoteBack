namespace InstantRemote.Core.Helpers
{
    public static class Constants
    {
        #region StartUp
        public const string AppNombre = "InstantRemote";
        public const string BDControl = "BDControl";
        public const string OriginsPolicy = "OriginsPolicy";
        public const string CustomSwaggerUi = "custom-swagger-ui";
        public const string VirtualDirectory = "VirtualDirectory";
        public const string Bearer = "Bearer";
        public const string BearerSpace = "Bearer ";
        public const string ExpirationMinutes = "JwtConfig:ExpiracionMinutos";
        public const string Redirect404 = "App:404";
        public const string DefinitionName = "Authorization";
        public const string BearerFormat = "JWT";
        public const string Username = "Username";
        public const string DbSeguridad = "DbSeguridad";
        public const string Dto = "Dto";
        public const string SwaggerExtensionXml = ".xml";
        public const string Char = "3NEbI=!#%^&&**(()_++)*^%#|I1lcrL5hIdrLq9Wa9udr!tuz?5tr4frobog1&PawRAc8riM1&7!$&(r+ST*f3ITHi";

        #endregion

        #region SwaggerConfig

        public const string ServiceVersion = "v1";
        public const string GetCatalog = "catalogs/{group}/{tower}";

        #region Seguridad

        public const string Security = "security";
        public const string SecurityTitle = "Security Manager";
        public const string SwaggerPathSeguridad = "../swagger/security/swagger.json";

        public const string RouteSecurity = "security/auth";

        public const string Authentication = "Authentication";
        public const string SignIn = "signin";
        public const string QueryProductId = "productId";
        public const string Encrypt = "encrypt";
        public const string EnvironmentVariable = "environment-variable";
        public const string ValidateToken = "validate-token";
        public const string ValidEmail = "validate-email";
        public const string SendTokenVerify = "token-email";
        public const string UpdatePassword = "password-update";
        
        public const string GetTokenStatus = "status-token";

        #endregion
        #region Catalogos
        public const string Catalogs = "catalogos";
        public const string CatalogsTitle = "Catalogos Manager";
        public const string SwaggerPathCatalogs = "../swagger/catalogos/swagger.json";

        
        public const string RouteCatalogs = "catalogos/";
        public const string RouteClientes = "catalogos/clientes";
        public const string RouteSecciones = "catalogos/secciones";
        public const string RouteHorarios = "catalogos/horarios";
        public const string RouteDiasFestivos = "catalogos/diasFestivos";
        public const string RoutePermisos = "catalogos/permisos";
        public const string RouteEmpleados = "catalogos/empleados";
        public const string RouteAsigna = "catalogos/asignaEmpleados";
        public const string RouteReports = "catalogos/reportes";
        public const string RouteToken = "catalogos/token";
        public const string RouteServicios = "catalogos/servicios";
        public const string RouteSites = "catalogos/sites";
        public const string RouteSucursal = "catalogos/sucursal";

        public const string Clientes = "Clientes";
        public const string Servicios = "Servicios";
        public const string Sites = "Sites";
        public const string Secciones = "Secciones";
        public const string Horarios = "Horarios";
        public const string Permisos = "Permisos";
        public const string TokenC = "Token";
        public const string Empleados = "Empleados";
        public const string Sucursal = "Sucursal";
        public const string DiasFestivos = "DiasFestivos";
        public const string AsignaEmpleado = "AsignaEmpleado";
        
         public const string GetCatZonaClientes = "CatZonaClientes";
        public const string GetResponsables = "responsables";
        public const string InsertCliente = "insert/cliente";
        public const string UpdateCliente = "update/cliente";
        public const string DeleteCliente = "delete/cliente";

        public const string GetHorariosAsigna = "horarios";
        public const string GetAsignacion = "get";
        public const string GetListaHorariosAsignaEdit = "get/edit";
        public const string AddAsignacion = "temp/add";
        public const string UpdateAsignacion = "temp/update";
        public const string DeleteAsignacion = "temp/delete";


        public const string GetClienteSeccion = "clientes-seccion";
        public const string GetClientesXPermisos = "GetClientesXPermisos";
        public const string GetCatalogoCliente = "GetCatalogoCliente";
        
        public const string GetSucursalesXPermisos = "GetSucursalesXPermisos";
        public const string GetSucursales = "sucursales";
        public const string GetAllSucursales = "all";
        public const string UpdateMasivoSucursal = "update/masivo";
        public const string GetSucursalSecciones = "sucursal-seccion";
        public const string GetSucursalCatalogo = "GetSucursalCatalogo";
        public const string GetSitesDetalle = "detalle/site";
        public const string GetBiometricosDetalle = "detalle/biometricos";
        public const string GetTelefonoDetalle = "detalle/telefono";
        public const string GetResponsableDetalle = "detalle/responsable";
        public const string GetHorarioDetalle = "detalle/horarios";
        public const string GetTelefonosSucursalN = "telefonos";
        public const string GetTelefonosSucursalById = "telefonosbyId";
        public const string GetSitesSucursalN = "sites";
        public const string GetBioSucursalN = "biometricos";
        public const string GetCandados = "candados";
        public const string InsertTelefonoSucursal = "telefono/insert";
        public const string InsertSucursal = "insert";
        public const string UpdateSucursal = "update";
        public const string DeleteSucursal = "delete";
        
        
        public const string GetSecciones = "secciones";
        public const string GetSeccion = "seccion";
        public const string GetSeccionSucursal = "seccion-sucursal";
        

        public const string GetSites = "sites";
        public const string GetSitesCliente = "sites-cliente";
        public const string GetSitesSucursal = "sites-sucursal";

        public const string GetServicio = "servicio";
        public const string GetServicioSucursal = "servicio-sucursal";
        public const string GetServicioSeccion = "servicio-seccion";
        
        
        public const string GetCatalogoHorario = "catalogo";
        public const string GetConstEnrola = "constantes/enrolado";
        public const string GetDispositivos = "dispositivos";
        public const string GetDispositivoDetalle = "dispositivos/detalles";
        public const string GetParameterByReference = "parametros";
        public const string UpdateParameter = "parametros/update";
        public const string GetTipoHorario = "tipo";
        public const string GetTipoCHorario = "tipo-comida";
        public const string GetNivelHorario = "nivel";
        public const string GetServicioHorario = "servicio";
        public const string AddHorario = "add";
        public const string DeleteHorario = "delete";
        public const string UpdateHorario = "update";

        
        public const string SaveToken = "add";
        public const string LiberaToken = "release";
        public const string DeleteToken = "delete";
        public const string GetCatalogoToken = "get";

        public const string GetEmpleadosCPermisos = "empleados";
        public const string GetEmpleadosSNPermisos = "empleados/sinPermisos";
        public const string GetMenusPermisos = "menus";
        public const string GetMenusPermisosEmpleado = "menusEmpleado";
        public const string InsertPermisosEmpleado = "add";
        public const string UpdatePermisosEmpleado = "update";
        public const string DeletePermisosEmpleado = "delete";
        public const string GetSeccionesEmpleado = "seccionesEmpleado";
        public const string GetSucursalEmpleadoClientes = "empleado/sucursal-clientes";


        public const string GetEmpleadosCatalogos = "getCatalogo";
        public const string GetEmpleados = "get";
        public const string GetEmpleadosDetalle = "getDetalle";
        public const string GetEmpleadosCatalogoTelefonos = "telefonos";
        public const string GetEmpleadosCatalogoEstatus = "estatus";
        public const string UpdateEmpleadosCatalogo = "update";
        public const string UpdateMasivoEmpleados = "updateMasivo";
        
        public const string GetDiasFestivos = "getCatalogo";
        public const string UpdateDiasFestivos = "update";
        public const string AddDiaFestivo = "add";
        public const string DeleteDiasFestivos = "delete";

        #endregion

        #region Common
        public const string Services = "common";
        public const string Filtros = "filtros";

        public const string ServicesTitle = "Services Manager";
        public const string SwaggerPathServices = "../swagger/common/swagger.json";

        public const string RouteCommon = "common/";
        public const string RouteFiltro = "filtro/";
            
        public const string GetReports = "reports";
        public const string Bitacora = "bitacora";
        public const string GetEstado = "estados";
        public const string GetYears = "years";
        public const string GetWeeks = "weeks";
        public const string GetMunicipios = "municipios";
        public const string GetColonia = "colonia";
        public const string GetCP = "cp";
        public const string GetZonaHoraria = "zona-horaria";
       
       
        
        #endregion

        #region Reportes
        public const string Reportes = "REPORTES";
        public const string Reports = "reportes";
        public const string SwaggerPathReports = "../swagger/reportes/swagger.json";
        public const string RouteReportes = "reportes/";
        public const string ReportesTitle = "Reportes Manager";

        public const string GetLogAsistencia = "logAsistencia";
        public const string GetRetardos = "retardos";
        public const string GetHuerfanos = "huerfanos";
        public const string GetReportClientes = "clientes";
        public const string GetReportHorasExtras = "horasExtras";
        public const string GetReportEdoEnrola = "estadoEnrolamiento";
        public const string GetReportAsistenciaAnual = "asistenciaAnual";

        

        #endregion
        
        #endregion

        #region Config api

        public const string ContentType = "application/json";

        #endregion


        #region simbolos

        public const string Slash = "/";
        public const string Plus = "+";
        public const string Equal = "=";
        public const string DoubleEqual = "==";
        public const string Punto = ".";
        public const string Coma = ",";
        public const string SlashBase64 = "_";
        public const string Base64Plus = "-";

        #endregion

        #region middleware

        public const string ControllerRegistro = "registro";
        public const string ControllerLogin = "login";
        public const string Prefijo = "7k5.";

        #endregion

        #region globase

        public const string OriginService = "Instant Remote Service";
        public const string InternalServerError = "Internal server error";
        public const string ReferenceVirtualDirectory = "VirtualDirectory";
        public const string ReferenceRootPath = "RootPath";
        public const string Authorization = "Authorization";
        public const string SecretKey = "SecretKeyJwt";
        public const string SecurityManager = "SecurityManagerKey";
        public const string Pipe = "|";
        public const string String = "string";

        #endregion

        #region claims
        public const string Email = "email";
        public const string ExiId = "exid";
        public const string Timespan = "timespan";
        #endregion

      

    }
}
