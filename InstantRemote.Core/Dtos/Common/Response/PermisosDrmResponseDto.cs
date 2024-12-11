using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Response
{
    public class PermisosDrmResponseDto
    {
        public int IdDRM { get; set; }
        public int NumEmpleado { get; set; }
        public int IdCliente { get; set; }
        public string NomClientes { get; set; }
        public int IdSucursal { get; set; }
        public string NomSucursal { get; set; }
        public bool Dashboard { get; set; }
        public bool Dispositivos { get; set; }
        public bool Empleados { get; set; }
        public bool Mapa { get; set; }
        public bool LibroAsistencia { get; set; }
        public bool RepLogAsistencia { get; set; }
        public bool RepRetardos { get; set; }
        public bool RepHuerfanos { get; set; }
        public bool RepCliente { get; set; }
        public bool RepEdoEnrolamiento { get; set; }
        public bool RepHorasExtras { get; set; }
        public bool RepRecordAsisAnual { get; set; }
        public bool RepRecordAsisResumen { get; set; }
        public bool RepAsistenciaEstandar { get; set; }
        public bool RepFichaAsistencia { get; set; }
        public bool RepAcumuladoAsis { get; set; }
        public bool RepAusentismos { get; set; }
        public bool RepAsistencia { get; set; }
        public bool RepApp { get; set; }
        public bool CatAsignaEmpleado { get; set; }
        public bool CatCliente { get; set; }
        public bool CatDiasFestivos { get; set; }
        public bool CatEmpleado { get; set; }
        public bool CatHorario { get; set; }
        public bool CatPermisos { get; set; }
        public bool CatSucursal { get; set; }
        public bool CatToken { get; set; }
        public bool RepTemperatura { get; set; }
        public bool RepAusenOmision { get; set; }
        public bool RepAsigTempo { get; set; }
        public bool RepConstantes { get; set; }
        public bool AutorizaHrasExtras { get; set; }
        public bool SolicitaHrasExtras { get; set; }
        public bool BloqueoManual { get; set; }
        public bool MatrizAprobacion { get; set; }
        public bool RepCapturaManual { get; set; }
        public bool RepHrasExtrasAuto { get; set; }
        public bool RepHrasExtrasNoProcedePago { get; set; }
        public bool CapturaMasiva { get; set; }
        public bool ActualizacionEmp { get; set; }
    }

    public class PermisosResponseDto : PermisosDrmResponseDto
    {
        public string Nombre { get; set; }

        public bool Variables { get; set; }
    }



}
