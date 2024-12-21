using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Services.Filtros
{
    public class ServiceFiltros : BaseService, IServiceFiltros
    {
        public ServiceFiltros(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public List<GetResponsablesRespDto> GetResponsables()
        {
            return UnitOfWork.RepositoryCommon.GetResponsables();
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


        public List<GetClienteCatalogoRespDto> GetCatalogoCliente()
        {
            return UnitOfWork.RepositoryCommon.GetCatalogoCliente();
        }

        public List<GetClienteCatalogoRespDto> GetClienteSecciones(int emplid, int otro)
        {
            return UnitOfWork.RepositoryCommon.GetClienteSecciones(emplid, otro);
        }

        public bool InsertCliente(CatalogoClienteReqDto dataCliente)
        {
            return UnitOfWork.RepositoryCommon.InsertCliente(dataCliente);
        }
        public bool UpdateCliente(CatalogoClientUpdateeReqDto dataCliente)
        {
            return UnitOfWork.RepositoryCommon.UpdateCliente(dataCliente);
        }
        public bool DeleteCliente(int idCliente)
        {
            return UnitOfWork.RepositoryCommon.DeleteCliente(idCliente);
        }

        public List<GetSucursalesRespDto> GetSucursalList(string clientId)
        {
            return UnitOfWork.RepositoryCommon.GetSucursales(clientId);
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


        public List<GetSucursalesRespDto> GetSucursalSecciones(int emplid, int secciones)
        {
            return UnitOfWork.RepositoryCommon.GetSucursalSecciones(emplid, secciones);
        }

        public List<CatalogoSucursaRespDto> GetSucursalCatalogo(int cliente, int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSucursalCatalogo(cliente, sucursal);
        }

        public List<GetSeccionesRespDto> GetSeccion(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSecciones(clientId, otro);
        }

        public List<GetSeccionesRespDto> GetSeccionesSucursales(int emplid, int otro)
        {
            return UnitOfWork.RepositoryCommon.GetSeccionesSucursales(emplid, otro);
        }

        public List<GetSitesRespDto> GetSites(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSites(clientId, otro);
        }

        public List<GetSitesRespDto> GetSitesCliente(int emplid, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetSitesCliente(emplid, otro);
        }
        public List<GetSitesRespDto> GetSitesSucursal(int emplid, string sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetSitesSucursal(emplid, sucursal);
        }

        public List<GetServicioRespDto> GetServicios(int clientId, string otro)
        {
            return UnitOfWork.RepositoryCommon.GetServicio(clientId, otro);
        }

        public List<GetServicioRespDto> GetServicioSucursal(int emplid, int sucursal)
        {
            return UnitOfWork.RepositoryCommon.GetServicioSucursal(emplid, sucursal);
        }

        public List<GetServicioRespDto> GetServicioSeccion(int emplid, int seccion)
        {
            return UnitOfWork.RepositoryCommon.GetServicioSeccion(emplid, seccion);

        }



    }
}
