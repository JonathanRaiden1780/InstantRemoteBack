using System.Text.Json.Serialization;

namespace InstantRemote.Core.Dtos.Common.Response
{
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
}
