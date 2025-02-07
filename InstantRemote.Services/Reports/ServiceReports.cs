using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Services.Reports
{
    public class ServiceReports : BaseService, IServiceReports
    {
        public ServiceReports(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }
        public List<LogAsistenciaResp> GetLogAsistencia (FiltrosReq filtro)
        {
            return  UnitOfWork.RepositoryReports.GetLogAsistencia(filtro);
        }
        public List<RetardosResp> GetRetardos(FiltrosRepReq filtro)
        {
            return UnitOfWork.RepositoryReports.GetRetardos(filtro);
        }
        public List<HuerfanosResp> GetHuerfanos (FiltroHuerfanos filtro)
        {
            return UnitOfWork.RepositoryReports.GetHuerfanos(filtro);
        }
        public List<GetReportesClientes> GetReportClientes(int emplid)
        {
            return UnitOfWork.RepositoryReports.GetReportClientes(emplid);
        }
        public List<GetReportesEnrolados> GetReportEdoEnrola(FiltroEdoEnrola filtro)
        {
            return UnitOfWork.RepositoryReports.GetReportEdoEnrola(filtro);
        }
        public List<GetReportesHrsExtras> GetReportHrsExtra (FiltroHrsExtra filtro)
        {
            return UnitOfWork.RepositoryReports.GetReportHrsExtra(filtro);
        }
    }
}
