using InstantRemote.Core.Messages;
using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Request
{
    public class GetRegSmsReq
    {
        public string numempleado { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
    }
    public class GetRegSms
    {
        public int idemplid { get; set; }
        public string nombre { get; set; }
        public string site { get; set; }
        public string desDepto { get; set; }
        public string estatus { get; set; }
        public string HoraInicial { get; set; }
        public string HoraInicialComida { get; set; }
        public string HoraFinalComida { get; set; }
        public string HoraFinal { get; set; }
        public string nomsucursal { get; set; }
        public string mensaje { get; set; }
    }
    public class GetRegTel
    {
        public int numEmpleado { get; set; }
        public string nombre { get; set; }
        public string site { get; set; }
        public string tipoDispositivo { get; set; }
        public string serieDispositivo { get; set; }
        public string estado { get; set; }
        public string checktime { get; set; }
        public string sucursalTelefono { get; set; }
    }
    public class GetPass
    {
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string status { get; set; }
        public string site { get; set; }
        public string desDepto { get; set; }
        public string pass { get; set; }
    }

    public class GetAltasMan
    {
        public string badgenumber { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string site { get; set; }
        public string desDepto { get; set; }
        public string ns { get; set; }
        public string nomSucursal { get; set; }
        public string TipoAlta { get; set; }
    }
    
    public class GetBitComMan
    {
        public int numeroEmpleado { get; set; }
        public string nombreUsuario { get; set; }
        public string numAquienLeRealizan { get; set; }
        public int total { get; set; }
    }

}
