using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using System.Net.Mail;
using System.Net;

namespace InstantRemote.Services.Soporte
{
    public class ServiceSoporte : BaseService, IServiceSoporte
    {
        public ServiceSoporte(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public List<GetRegSms> GetRegSms(GetRegSmsReq req)
        {
            return UnitOfWork.RepositorySoporte.GetRegSms(req);
        }
        public List<GetRegTel> GetRegTel(string req)
        {
            return UnitOfWork.RepositorySoporte.GetRegTel(req);
        }
    }
}
