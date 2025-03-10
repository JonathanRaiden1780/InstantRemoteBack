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
    }
}
