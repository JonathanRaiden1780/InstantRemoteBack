using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Services.Parameters
{
    public class ServiceParameter : BaseService, IServiceParameter
    {
        public ServiceParameter(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }
        public void InsertBitacora(BitacoraRequestDto bitacora)
        {
            UnitOfWork.RepositoryCommon.InsertBitacoraInstantRemote(bitacora);
        }

        public List<GetYearResp> GetYears()
        {
            return UnitOfWork.RepositoryCommon.GetYears();
        }
        public List<GetWeekResp> GetWeeks (int year)
        {
            return UnitOfWork.RepositoryCommon.GetWeeks(year);
        }

        public List<GetParameter> GetParameterByGroup(string group)
        {
            return UnitOfWork.RepositoryParameter.GetParametersByGroup(group);
        }

        public GetParameter GetParameter(ParameterDto parameter)
        {
            var getParameter = UnitOfWork.RepositoryParameter.GetParameter(parameter);
            return getParameter;
        }

        public GetParameter GetParameterByReference(string reference)
        {
            var getParameter = UnitOfWork.RepositoryParameter.GetParameterByReference(reference);
            return getParameter;
        }
        public bool UpdateParameter(string reference, string value)
        {
            var getParameter = UnitOfWork.RepositoryParameter.UpdateParameter(reference, value);
            return getParameter;
        }
        
        public List<GetCP> GetCP(int estado, int mun, int col)
        {
            return  UnitOfWork.RepositoryParameter.GetCP(estado,mun,col);
        }

        public List<GetMunicipio> GetMunicipio(int estado)
        {
            return  UnitOfWork.RepositoryParameter.GetMunicipio(estado);
        }

        public List<GetColonia> GetColonia(int estado, int mun)
        {
            return  UnitOfWork.RepositoryParameter.GetColonia(estado,mun);
        }

        public List<GetEstados> GetEstados()
        {
            return  UnitOfWork.RepositoryParameter.GetEstados();
        }

        public List<GetZonaHoraria> GetZonaHoraria()
        {
            return  UnitOfWork.RepositoryParameter.GetZonaHoraria();
        }
    }
}
