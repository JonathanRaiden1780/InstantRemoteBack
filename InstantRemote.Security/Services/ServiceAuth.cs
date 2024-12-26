using System.Reflection.Metadata;
using AutoMapper;
using InstantRemote.Core.Messages;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Exceptions;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Helpers.Security;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Security.Services
{
    public class ServiceAuth : BaseService, IServiceAuth
    {
        public ServiceAuth(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IServiceFactorySecurity serviceFactorySecurity, IMapper mapper, IConfiguration configuration) : base(UnitOfWork, serviceFactorySecurity, serviceFactory, mapper, configuration)
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

        public GetTokenRespDto GetTokenStatus(int emplid)
        {
            return UnitOfWork.RepositoryAuth.GetTokenStatus(emplid);
        }

        public string SendTokenVerify(int emplid)
        {
            var user =  UnitOfWork.RepositoryAuth.ValidEmail(emplid);
            string token = "";
            var htmlBody = Utils.PasswordChangeTemplate;
            var subject = "Código de seguridad de Instant Remote";
            if (user != null)
            {
                Random random = new Random();
                for (int i = 0; i < 6; i++)
                {
                    token += random.Next(0, 10).ToString();
                }
                htmlBody = htmlBody.Replace("{userName}", user.name).Replace("{nip}", token);
                //serviceFactory("IR").ServiceCommon.SendMail(user.mail, subject, htmlBody);
            }
            return token;
        }

        public bool UpdatePassword(ChangePassReqDto newData)
        {
            return UnitOfWork.RepositoryAuth.UpdatePassword(newData);
        }

    }
}



