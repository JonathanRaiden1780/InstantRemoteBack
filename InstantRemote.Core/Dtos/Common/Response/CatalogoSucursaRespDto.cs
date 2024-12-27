using InstantRemote.Core.Messages;
using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Response
{
    public class CatalogoSucursaRespDto
    {
        public int IdDeptoSucursal { get; set; }
        public string NomSucursal { get; set; }
        public string NomCliente { get; set; }
        public string Domicilio { get; set; }
        public string FechaAlta { get; set; }
        public string NumSite { get; set; }
        public string PlanAuto { get; set; }
        public string Notas { get; set; }
        public string ZonaHoraria { get; set; }
        public string OrigenLlamado { get; set; }
        public string Biometricos { get; set; }
        public string Telefonos { get; set; }
        public string Horario { get; set; }
        public string Responsable { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NumExt { get; set; }
        public int Id_CP { get; set; }
        public int IdCliente { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string NumInt { get; set; }
        public bool AlBio { get; set; }
        public bool AlInc { get; set; }
        public bool AlPlan { get; set; }
        public bool AlTol { get; set; }
        public bool AlPlanI { get; set; }
        public string Site_Hijo1 { get; set; }
        public string Site_Hijo2 { get; set; }
        public string Site_Hijo3 { get; set; }
        public int IdSeccion { get; set; }
        public int IdZonaHoraria { get; set; }
        public string IdTelefonos { get; set; }
        public string IdSites { get; set; }
        public int id_edo { get; set; }
        public int id_mun { get; set; }
        public int IdOLL { get; set; }
        public int id_col { get; set; }
    }

    public class DetalleTelefonosRespDto
    {
        public string idTel { get; set; }
        public string numTel { get; set; }
    }
    
    public class DetalleSitesRespDto
    {
        public string idSite { get; set; }
        public string nameSite { get; set; }
    }
    public class DetalleBiometricosRespDto
    {
        public string ns { get; set; }
    }
    
    public class DetalleHorariosRespDto
    {
        public string idHorario { get; set; }
        public string nombre { get; set; }
    }
    public class DetalleResponsableRespDto
    {
        public string id { get; set; }
        public string responsable { get; set; }
    }

    public class TelefonosSucursalN
    {
        public int idTel { get; set; }
        public string numTel { get; set; }
        public int tipo { get; set; }
    } 
    
    public class SitesSucursalN
    {
        public int ID_SITE { get; set; }
        public string DEPTIID { get; set; }
    } 
    
    public class BioSucursalN
    {
        public string SN { get; set; }
    }
    
    public class SucursaUpdateDto
    {
        public string NomSucursal { get; set; }
        public string Responsable { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string CP { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public int IdSucursal { get; set; }
        public int IdCliente { get; set; }
        public string NumSite { get; set; }
        public string PlanAuto { get; set; }
        public string Notas { get; set; }
        public string ZonaHr { get; set; }
        public string NomCliente { get; set; }
        public string IdOrigenLlamado { get; set; }
        public string IdSeccion { get; set; }
        public string Empleado { get; set; }
        public string SiteHijo1 { get; set; }
        public string SiteHijo2 { get; set; }
        public string SiteHijo3 { get; set; }
        public int AlBio { get; set; }
        public int AlInc { get; set; }
        public int AlTol { get; set; }
        public int AlPlan { get; set; }
        public int AlPlanI { get; set; }
        public string Telefonos { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Ns { get; set; }
    }
   
    public class SucursalInsertDTO
    {
        public string NomSucursal { get; set; }
        public string Responsable { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string CP { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdCliente { get; set; }
        public string NumSite { get; set; }
        public string PlanAuto { get; set; }
        public string Notas { get; set; }
        public string ZonaHr { get; set; }
        public string NomCliente { get; set; }
        public string IdOrigenLlamado { get; set; }
        public string IdSeccion { get; set; }
        public string Empleado { get; set; }
        public string SiteHijo1 { get; set; }
        public string SiteHijo2 { get; set; }
        public string SiteHijo3 { get; set; }
        public string Ns { get; set; }
        public int? AlBio { get; set; }
        public int? AlInc { get; set; }
        public int? AlTol { get; set; }
        public int? AlPlan { get; set; }
        public int? AlPlanI { get; set; }
        public string Telefonos { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
    }

    public class GetCandados
    {  
        public int idOLL { get; set; }
        public string descripcionOLL { get; set; }
    }
    public class NewTelefonoSucursal
    {  
        public string numTel { get; set; }
        public string tipo { get; set; }
        public string @numSerie { get; set; }
    }
}