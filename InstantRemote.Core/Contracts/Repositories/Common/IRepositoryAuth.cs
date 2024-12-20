using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryAuth
    {
        PermisosResponseDto Login(SingInReqDto signIn);
        PermisosDrmResponseDto GetUserPermiso(string emplid);
        GetTokenRespDto GetTokenStatus(int emplid);


    }
}
