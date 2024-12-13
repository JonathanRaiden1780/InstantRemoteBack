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
        public List<GetCatZonaClientesRespDto> GetClientesXPermisos(int emplid)
        {
            List<GetCatZonaClientesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid.ToString());
            var nivel = userPermiso.IdCliente;

            switch (nivel)
            {
                case "0":
                    response = UnitOfWork.RepositoryCommon.GetCatZonaClientes(emplid.ToString(), null);
                    break;
                case "000":
                    response = UnitOfWork.RepositoryCommon.GetClienteSeccion(emplid);
                    break;
                case "000000":
                    response = UnitOfWork.RepositoryCommon.GetClienteSite(emplid);
                    break;
                default:
                    response = UnitOfWork.RepositoryCommon.GetClienteJerarquiaOtro(emplid);
                    break;
            }

            return response;
        }

        public List<GetSucursalesRespDto> GetSucursalList(string clientId)
        {
            return  UnitOfWork.RepositoryCommon.GetSucursales(clientId);
        }
        public List<GetSucursalesRespDto> GetSucursalesXPermisos(int emplid, string cliente)
        {
            List<GetSucursalesRespDto> response = [];
            var userPermiso = UnitOfWork.RepositoryAuth.GetUserPermiso(emplid.ToString());
            var nivel = userPermiso.IdCliente;

            switch (nivel)
            {
                case "0":
                    response = UnitOfWork.RepositoryCommon.GetSucursales(cliente);
                    break;
                case "000":
                    response = UnitOfWork.RepositoryCommon.GetSucursalesSeccion(emplid, cliente);
                    break;
                case "000000":
                    response = UnitOfWork.RepositoryCommon.GetSucursalesSite(emplid, cliente);
                    break;
                default:
                    response = UnitOfWork.RepositoryCommon.GetSucursalesJerarquiaOtro(emplid, cliente);
                    break;
            }

            return response;
        }

        public List<GetSeccionesRespDto> GetSeccion(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSecciones(clientId, otro);
        }
        public List<GetSitesRespDto> GetSites(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSites(clientId, otro);
        }
        public List<GetServicioRespDto> GetServicios(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetServicio(clientId, otro);
        }

    }
}
