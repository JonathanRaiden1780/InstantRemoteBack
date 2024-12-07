using SingInDto = InstantRemote.Core.Dtos.Common.Request.SingInDto;
using TokenDto = InstantRemote.Core.Dtos.Common.Response.TokenDto;
using ValidateTokenDto = InstantRemote.Core.Dtos.Common.Request.ValidateTokenDto;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceAuth
    {
        TokenDto SignIn(SingInDto singIn);
        void ValidateToken(ValidateTokenDto tokenDto);
    }
}
