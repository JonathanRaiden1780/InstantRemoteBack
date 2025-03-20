using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServicePrincipal
    {
        List<GetConstEnrolaRsp> GetConstEnrola(int tipo);
        List<GetDispositivosResp> GetDispositivos(int emplid);
        List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie);
        List<GetSolHrsExtras> GetSolHrsExtras(string emplid);
        List<GetSolHrsExtrasDetalle> GetSolHrsExtrasDetalle(string id);
        List<GetSolHrsExtrasAll> GetSolHrsExtrasAll();
        string CaducarVigencia(CaducarVigenciaReq request);
        string QuitarVigencia(CaducarVigenciaReq request);
        List<GetEmpleadoInfo> GetInfoName(string emplid);
        string validaCalendar(string desde);
        string SaveHrsExtra(SaveSolicitudHrsReq request);
        List<GetAutHrsExtras> GetAutHrsExtras(string emplid);
    }
}
