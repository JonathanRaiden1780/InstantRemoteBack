using System.Text.Json.Serialization;

namespace InstantRemote.Core.Dtos.Common.Response
{
    public class GetCatZonaClientesRespDto
    {
        public int id { get; set; }
        public string cliente { get; set; }
    }
}
