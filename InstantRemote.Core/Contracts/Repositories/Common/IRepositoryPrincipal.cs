using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryPrincipal
    {
        List<GetDispositivosResp> GetDispositivos(int emplid);
        List<GetConstEnrolaRsp> GetConstEnrola(int tipo);
        List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie);
        List<GetSolHrsExtras> GetSolHrsExtras(string emplid);
        List<GetSolHrsExtrasDetalle> GetSolHrsExtrasDetalle(string id);
        List<GetSolHrsExtrasAll> GetSolHrsExtrasAll();
        string CaducarVigencia(CaducarVigenciaReq request);
        string QuitarVigencia(CaducarVigenciaReq request);
        List<GetEmpleadoInfo> GetInfoName(string emplid);
        string ValidaCalendar(string desde);
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
    }
}
