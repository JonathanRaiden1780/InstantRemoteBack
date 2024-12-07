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

namespace InstantRemote.Security.Services
{
    public class ServiceAuth : BaseService, IServiceAuth
    {
        public ServiceAuth(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IServiceFactorySecurity serviceFactorySecurity, IMapper mapper, IConfiguration configuration) : base(UnitOfWork, serviceFactorySecurity, mapper, configuration)
        {
        }
        //método no esta en uso aun
        public res.TokenDto SignIn(SingInDto singIn)
        {
            User user = new User(); // UnitOfWork.RepositoryAuth.GetUserByNickNamePassword(singIn.Username, singIn.Password);
            if (user is null)
                throw new BusinessException(MessageServices.KOResponseSignInNull);

            return JwtConfig.ObtenerToken(singIn.Username, SecretKey, expiracionMinutos);
        }

        public res.TokenDto SignInTeChreo(string seed)
        {
            string uniqueClientId = seed.Decrypt().GetSeed();
    /*        var Seed = UnitOfWork.RepositorySeedExpiration.GetSeedExpirationBySeedAndCudId(seed, uniqueClientId);
            if (Seed == null) throw new BusinessException(MessageServices.KOResponseSignIn);
            if (Seed.IsActive)
                UnitOfWork.RepositorySeedExpiration.UpdateSeedExpirationSetActive(seed, uniqueClientId);
*/
            res.TokenDto token = JwtConfig.ObtenerToken(uniqueClientId, SecretKey, expiracionMinutos);

            token.CudId = uniqueClientId;

            return token;
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



