namespace InstantRemote.Core.Dtos.Common.Response
{
    public class TokenRespDto
    {       
        public string Token { get; set; }

        public PermisosResponseDto User { get; set; }

    }
    public class GetTokenRespDto
    {
        public int numEmpleado { get; set; }
        public string TokenID { get; set; }
        public string estado { get; set; }
        public string Tipo { get; set; }

    }


}
