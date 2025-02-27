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
        List<GetReportAsistenciaAnual> GetReportAsistenciaAnual(FiltroAsistenciaAnual filtro);
        List<GetReportAsistenciaAnualResumen> GetReportAsistenciaAnualResumen(FiltroAsistenciaAnualResumen filtro);
        List<GetReportAsistenciaEstandar> GetReportAsistenciaEstandar(FiltroAsistenciaAnualResumen filtro);
        List<GetReportAcumuladoAsistencia> GetReportAcumuladoAsistencia(FiltroAsistenciaAcumulado filtro);
        List<GetReportAusentismos> GetReportAusentismos(FiltroAusentismos filtro);
        List<GetReportAsistencia> GetReportAsistencia(FiltroAsistencia filtro);
        List<GetReportAsistenciaTemp> GetReportAsistenciaTemperatura(FiltroAsistencia filtro);
        List<GetReportApp> GetReportApp(FiltroApp filtro);
    }
}
