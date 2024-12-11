using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using ValidateTokenDto = InstantRemote.Core.Dtos.Common.Request.ValidateTokenDto;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceAuth
    {
        TokenRespDto SignIn(SingInReqDto singIn);
        void ValidateToken(ValidateTokenDto tokenDto);
    }
}
