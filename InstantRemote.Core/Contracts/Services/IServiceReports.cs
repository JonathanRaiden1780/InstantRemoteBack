using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceReports
    {
        List<LogAsistenciaResp> GetLogAsistencia(FiltrosReq filtro);
        List<RetardosResp> GetRetardos(FiltrosRepReq filtro);
        List<HuerfanosResp> GetHuerfanos(FiltroHuerfanos filtro);
        List<GetReportesClientes> GetReportClientes(int emplid);
        List<GetReportesEnrolados> GetReportEdoEnrola(FiltroEdoEnrola filtro);
        List<GetReportesHrsExtras> GetReportHrsExtra(FiltroHrsExtra filtro);
    }
}
