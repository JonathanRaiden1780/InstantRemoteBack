using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositorySoporte
    {
        List<GetRegSms> GetRegSms(GetRegSmsReq req);
        List<GetRegTel> GetRegTel(string req);
        List<GetPass> GetPass(string req);
    }
}
