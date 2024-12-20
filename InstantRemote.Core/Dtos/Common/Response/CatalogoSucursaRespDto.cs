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
        public int IdCP { get; set; }
        public int IdCliente { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string NumInt { get; set; }
        public bool AlBio { get; set; }
        public bool AlInc { get; set; }
        public bool AlPlan { get; set; }
        public bool AlTol { get; set; }
        public bool AlPlanI { get; set; }
        public string SiteHijo1 { get; set; }
        public string SiteHijo2 { get; set; }
        public string SiteHijo3 { get; set; }
        public int IdSeccion { get; set; }
        public int IdZonaHoraria { get; set; }
        public string IdTelefonos { get; set; }
        public string IdSites { get; set; }
        public int IdEdo { get; set; }
        public int IdMun { get; set; }
        public int IdOLL { get; set; }
        public int IdCol { get; set; }
    }


}
