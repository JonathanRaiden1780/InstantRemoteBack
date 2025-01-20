using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryReports
    {
        List<LogAsistenciaResp> GetLogAsistencia(FiltrosReq filtro);
    }
}
