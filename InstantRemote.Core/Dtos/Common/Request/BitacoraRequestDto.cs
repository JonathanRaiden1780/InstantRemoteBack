namespace InstantRemote.Core.Dtos.Common.Request
{
    public class BitacoraRequestDto
    {
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string DetalleAdicional { get; set; }

    }
}
