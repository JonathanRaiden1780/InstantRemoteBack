

using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceSoporte
    {
        List<GetRegSms> GetRegSms(GetRegSmsReq req);
        List<GetRegTel> GetRegTel(string req);
        List<GetPass> GetPass(string req);
        List<GetAltasMan> GetAltasMan();
        List<GetBitComMan> GetBitComMan(string fechaIni, string fechaFin);
        List<GetTipoTel> GetTipoTel(string numTelefonico);
        List<GetPantalla> GetPantallas();
        List<GetPanAccion> GetPantAccion(string pantalla);
        List<GetBitacora> GetBitacora(GetBitacoraReq req);
    }
}
