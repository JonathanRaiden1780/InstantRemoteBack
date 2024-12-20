namespace InstantRemote.Core.Dtos.Common.Response
{

    public class GetResponsablesRespDto
    {
        public int id { get; set; }
        public string responsable { get; set; }
    }

    public class GetCatZonaClientesRespDto
    {
        public int id { get; set; }
        public string cliente { get; set; }
    }
    public class GetSucursalesRespDto
    {
        public int id { get; set; }
        public string sucursal { get; set; }
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
}
