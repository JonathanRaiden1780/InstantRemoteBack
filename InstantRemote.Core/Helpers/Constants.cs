namespace InstantRemote.Core.Helpers
{
    public static class Constants
    {
        #region StartUp
        public const string AppNombre = "IntegrationService";
        public const string BDControl = "BDControl";
        public const string OriginsPolicy = "TksOriginsPolicy";
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
        public const string IdentityTransferTechreo = "identity-transfer-techreo";
        public const string SignInTechero = "signin-techreo";
        public const string QueryProductId = "productId";
        public const string Encrypt = "encrypt";
        public const string EnvironmentVariable = "environment-variable";
        public const string ValidateToken = "validate-token";
        

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
