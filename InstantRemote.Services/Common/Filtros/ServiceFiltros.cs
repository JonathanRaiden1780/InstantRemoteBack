using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using enums = InstantRemote.Core.Enums;
using Newtonsoft.Json;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Services.Common.Filtros
{
    public class ServiceFiltros : BaseService, IServiceFiltros
    {
        public ServiceFiltros(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid)
        {
            List<GetCatZonaClientesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid);
            var admin = userPermiso.IdCliente.Contains(',') ? false :
                int.Parse(userPermiso.IdCliente) == 0 ? true : false;
            if (admin)
                response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid, null);
            else
                response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid, userPermiso.IdCliente);

            return response;
        }


    }
}
