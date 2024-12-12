using AutoMapper;
using InstantRemote.Core.Messages;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Helpers.Security;
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
            UnitOfWork.RepositoryCommon.InsertBitacoraInstantRemote(new BitacoraRequestDto()
            {
                Accion = "ACCESO",
                Pantalla = "LOGUIN",
                Descripcion = "El empleado " + response.User.NumEmpleado + " ENTRO AL SISTEMA ",
                DetalleAdicional = "",
                Fecha = DateTime.Now,
                Usuario = response.User.NumEmpleado.ToString()
            });
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



