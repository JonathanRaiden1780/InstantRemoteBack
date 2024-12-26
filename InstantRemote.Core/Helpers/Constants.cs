namespace InstantRemote.Core.Helpers
{
    public static class Constants
    {
        #region StartUp
        public const string AppNombre = "IntegrationService";
        public const string BDControl = "BDControl";
        public const string OriginsPolicy = "OriginsPolicy";
        public const string CustomSwaggerUi = "custom-swagger-ui";
        public const string VirtualDirectory = "VirtualDirectory";
        public const int CoreId = 1;
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
        public const string TchAccessControl = "tks-tch-access-control";
        public const string UserAccessControl = "user-access-control";
        public const string GenerateRedirect = "generate-redirect";
        public const string IdentityTransfer = "identity-transfer";
        public const string QueryProductId = "productId";
        public const string Encrypt = "encrypt";
        public const string EnvironmentVariable = "environment-variable";
        public const string ValidateToken = "validate-token";
        public const string ValidEmail = "validate-email";
        public const string SendTokenVerify = "token-email";
        public const string UpdatePassword = "password-update";
        
        public const string GetTokenStatus = "status-token";

        #endregion

        #region Common
        public const string Services = "common";

        public const string ServicesTitle = "Services Manager";
        public const string SwaggerPathServices = "../swagger/common/swagger.json";

        public const string Common = "common";
        public const string RouteCommon = "common/";

        public const string Clientes = "Clientes";
        public const string Servicios = "Servicios";
        public const string Sites = "Sites";
        public const string Secciones = "Secciones";
        public const string Sucursal = "Sucursal";

        public const string RouteClientes = "common/clientes";
        public const string RouteSecciones = "common/secciones";
        public const string RouteServicios = "common/servicios";
        public const string RouteSites = "common/sites";
        public const string RouteSucursal = "common/sucursal";
            
        public const string GetReports = "reports";
        public const string Bitacora = "bitacora";
        public const string GetEstado = "estados";
        public const string GetMunicipios = "municipios";
        public const string GetColonia = "colonia";
        public const string GetCP = "cp";
        public const string GetZonaHoraria = "zona-horaria";
        public const string Reportes = "REPORTES";

        public const string GetCatZonaClientes = "CatZonaClientes";
        public const string GetResponsables = "responsables";
        public const string InsertCliente = "insert/cliente";
        public const string UpdateCliente = "update/cliente";
        public const string DeleteCliente = "delete/cliente";



        public const string GetClienteSeccion = "clientes-seccion";
        public const string GetClientesXPermisos = "GetClientesXPermisos";
        public const string GetCatalogoCliente = "GetCatalogoCliente";
        
        public const string GetSucursalesXPermisos = "GetSucursalesXPermisos";
        public const string GetSucursales = "sucursales";
        public const string GetSucursalSecciones = "sucursal-seccion";
        public const string GetSucursalCatalogo = "GetSucursalCatalogo";
        public const string GetSitesDetalle = "detalle/site";
        public const string GetBiometricosDetalle = "detalle/biometricos";
        public const string GetTelefonoDetalle = "detalle/telefono";
        public const string GetResponsableDetalle = "detalle/responsable";
        public const string GetHorarioDetalle = "detalle/horarios";
        public const string GetTelefonosSucursalN = "telefonos";
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

        public const string CMEMBU = "CMEMBU";
        public const string SICPalnegocio = "SICPalnegocio";
        public const string Techreo = "Techreo";
        public const string Freedom = "TechreoApp";
        public const string ProductosPalNegocio = "palnegocio";
        public const string ProductosPalNegocioM = "palnegocio_m";
        public const string CancellationType = "Cliente";
        public const string Fee01 = "SEG_01";
        public const string Fee02 = "RET_01";
        public const string TypeProductMambuPalN = "PALNEGOCIO_M";
        public const string TypeProductMambuPLCS = "PA_LA_CASA";
        public const string TypeProductMambuPLNC = "PALQ_TRABAJA";
        public const string Empresa = "CME";

        public const string ContratoConfigPALACASA = "DOCUMENTS_SERVICE_CONFIG_PALACASA";
        public const string ContratoConfigPALENCA = "DOCUMENTS_SERVICE_CONFIG_PalqueTrabaja";
        public const string ContratoConfigPALN = "DOCUMENTS_SERVICE_CONFIG";

        public const string OriginService = "Integration Service";
        public const string InternalServerError = "Internal server error";
        public const string ReferenceVirtualDirectory = "VirtualDirectory";
        public const string ReferenceRootPath = "RootPath";
        public const string DataProtectorKey = "Wr?d!*NIcre4R#blSp?kDAv$Dex_FusplC6UPruw";
        public const string InterpolacionCode = "{codigo}";
        public const string InterpolacionEmail = "{Email}";
        public const string FromFileImage = "FromFileImage";
        public const string FromFileVideo = "FromFileVideo";
        public const string Image = "image";
        public const string MP4 = "mp4";
        public const string InvalidSizeImage600 = "InvalidSizeImage600";
        public const int MinSizeImage600 = 600;
        public const string Token = "Bearer {0}";
        public const string Authorization = "Authorization";
        public const string SeonXApiKey = "X-API-KEY";
        public const string SeonContentType = "Content-Type";
        public const string MiddleDash = "-";
        public const string Unattended = "UNATTENDED";
        public const string SecretKey = "SecretKeyJwt";
        public const string SecurityManager = "SecurityManagerKey";
        public const string Pipe = "|";
        public const string XBasicAuth = "x-basic-authorization";
        public const string InvalidUserKey = "Invalid User Key";
        public const string String = "string";
        public const string TechreoWallet = "Techreo Wallet (CITI)";
        public const string TechreoWalletFreedom = "Techreo Wallet (Freedom)";
        public const string EnvironmentApplication = "EnvironmentApplication";
        public const string SubEntityOnsigna = "subEntityOnsigna";
        public const string LadaRegion = "52";

        #endregion

        #region claims
        public const string Email = "email";
        public const string ExiId = "exid";
        public const string Timespan = "timespan";
        #endregion

      

    }
}
