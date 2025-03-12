using System.Text;
using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Services.Filtros
{
    public class ServicePrincipal : BaseService, IServicePrincipal
    {
        public ServicePrincipal(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public List<GetConstEnrolaRsp> GetConstEnrola(int tipo)
        {
            return UnitOfWork.RepositoryPrincipal.GetConstEnrola(tipo);
        }

        public List<GetDispositivosResp> GetDispositivos(int emplid)
        {
            return UnitOfWork.RepositoryPrincipal.GetDispositivos(emplid);
        }

        public List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie)
        {
            return UnitOfWork.RepositoryPrincipal.GetDispositivoDetalle(serie);
        }
        public List<GetSolHrsExtras> GetSolHrsExtras(string emplid)
        {
            return UnitOfWork.RepositoryPrincipal.GetSolHrsExtras(emplid);
        }
        public List<GetSolHrsExtrasDetalle> GetSolHrsExtrasDetalle(string id)
        {
            return UnitOfWork.RepositoryPrincipal.GetSolHrsExtrasDetalle(id);
        }
        public List<GetSolHrsExtrasAll> GetSolHrsExtrasAll()
        {
            return UnitOfWork.RepositoryPrincipal.GetSolHrsExtrasAll();
        }

        public string CaducarVigencia(CaducarVigenciaReq request)
        {
            return UnitOfWork.RepositoryPrincipal.CaducarVigencia(request);
        }

        public string QuitarVigencia(CaducarVigenciaReq request)
        {
            return UnitOfWork.RepositoryPrincipal.QuitarVigencia(request);
        }
        public List<GetEmpleadoInfo> GetInfoName(string emplid)
        {
            return UnitOfWork.RepositoryPrincipal.GetInfoName(emplid);
        }
        public string validaCalendar(string desde)
        {
            return UnitOfWork.RepositoryPrincipal.ValidaCalendar(desde);
        }
        public string SaveHrsExtra(SaveSolicitudHrsReq request)
        {
            return UnitOfWork.RepositoryPrincipal.SaveHrsExtra(request);
        }
        
    }
}
