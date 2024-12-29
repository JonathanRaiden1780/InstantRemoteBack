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
    
    public class TokenAdd : TokenMod{
        public string tipoToken { get; set; }
    }
    
    public class TokenMod {
        public string emplid { get; set; }
        public string numEmpleado { get; set; }
    }
}
