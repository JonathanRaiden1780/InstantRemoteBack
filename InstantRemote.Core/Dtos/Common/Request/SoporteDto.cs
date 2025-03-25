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


}
