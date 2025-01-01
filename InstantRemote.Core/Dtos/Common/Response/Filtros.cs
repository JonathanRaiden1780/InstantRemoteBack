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
    
}