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
        string AutHrsExtras(AutHrsExtrasReq request);
        List<AutVarInd> GetAutVarInd(string emplid);
        List<AutVarInd> GetAutVarJer(string emplid);
        List<GetVarAut> GetVarAutorizar(string numeroEmpleado, string calendario);
        void AutVariable(AutVarReq req);
        string GetVigencia(string cal);
        string VigenciaVar(VigenciaVarReq req);
        List<GetConcepto> GetConcepto();
        void UpdateVar(UpdateVarReq req);

        List<GetLibAsis>GetLibroAsis(GetLibAsisReq req);
        List<GetInfoCheckAppV> GetInfoCheckAppV(GetInfoCheckAppVReq req);
        List<GetInfoCheckApp> GetInfoCheckApp(GetInfoCheckAppReq req);
        List<GetInfoCheckBio> GetInfoCheckBio(GetInfoCheckBioReq req);
        List<GetInfoCheckMan> GetInfoCheckMan(GetInfoCheckManReq req);
        string GetInfoCheckAudio(GetInfoCheckAudioReq req);
        string UpdateCheckAsis(UpdateCheckReq req);
        bool SaveCheckMan(SaveCheckReq req);
        bool SaveCheckComMan(SaveCheckManReq req);
    }
}
