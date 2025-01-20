using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceReports
    {
        List<LogAsistenciaResp> GetLogAsistencia(FiltrosReq filtro);
        List<RetardosResp> GetRetardos(FiltrosReq filtro);
    }
}
