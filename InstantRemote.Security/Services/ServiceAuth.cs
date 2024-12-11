using AutoMapper;
using InstantRemote.Core.Messages;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Services;
using res = InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Helpers.Security;
using InstantRemote.Core.EntitiesStore.Common;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Security.Services
{
    public class ServiceAuth : BaseService, IServiceAuth
    {
        public ServiceAuth(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IServiceFactorySecurity serviceFactorySecurity, IMapper mapper, IConfiguration configuration) : base(UnitOfWork, serviceFactorySecurity, mapper, configuration)
        {
        }
        public TokenRespDto SignIn(SingInReqDto singIn)
        {
            TokenRespDto response = new TokenRespDto(); 
            var userData = UnitOfWork.RepositoryAuth.Login(singIn);
            if (userData is null)
                throw new BusinessException(MessageServices.KOResponseSignInNull);

            var token = JwtConfig.ObtenerToken(singIn.Username, SecretKey, expiracionMinutos);
            response.User = userData;
            response.Token = token.Token;
            return response;
        }

     
        public void ValidateToken(ValidateTokenDto tokenDto)
        {
            string tokenDecript = tokenDto.Token.DesencriptarToken();
            string uniqueClientId = tokenDto.Seed.Decrypt().GetSeed();
          //  bool isValid = UnitOfWork.RepositoryAuth.ValidateToken(new req.TokenDto() { Token = tokenDecript, UniqueClientId = uniqueClientId }, tokenDto.Seed);
          //  if (!isValid)
            //    throw new BusinessException(MessageServices.KOResponseGenerate);

        }

    }
}



