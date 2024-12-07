using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;
using System;
using System.Data;
using Dapper;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Helpers.Security;
using System.Linq;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryAuth : BaseRepository, IRepositoryAuth
    {
        public RepositoryAuth(IDbConnection connection, Func<IDbTransaction> transaction) : base(connection, transaction)
        {

        }
        public string ActivationMail(string exid)
        {
            throw new NotImplementedException();
        }

       

        public string ChangePassword(ChangePasswordDto cambio, string exid)
        {
            throw new NotImplementedException();
        }

       
        public User GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public string GetLogToken(TokenDto token)
        {
            throw new NotImplementedException();
        }

   /*     public User GetUserByNickNamePassword(string nickname, string password)
        {
            eventLog.Entrar();
            var respose = Connection.QueryFirstOrDefault(StoreProcedure.GetUserByNickNamePassword, new { @nickName=nickname, @password=password },commandType:CommandType.StoredProcedure);
            eventLog.Salir();
            return respose;
        }*/

        /*public void RegisterLogToken(TokenDto token)
        {
            eventLog.Entrar();
            Connection.Execute(StoreProcedure.RegisterLogToken);
            eventLog.Salir();
        }

        public int Registration(User user)
        {
            eventLog.Entrar();

            int userId = Connection.Query<int>(StoreProcedure.RegisterUser, new { 
                                @nickname = user.Nickname, 
                                @password = SecurityManager.Encrypt(user.Password) 
                        },commandType:CommandType.StoredProcedure).FirstOrDefault();
            
            eventLog.Salir();

            return userId;
        }*/

      /*  public string UpdatePassword(UpdatePasswordDto recuperar)
        {
            throw new NotImplementedException();
        }

        public bool ValidateToken(TokenDto token, string seed)
        {
            
            eventLog.Entrar();
            var response = Connection.Query<int>(StoreProcedure.ValidateToken, new { 
                                    @uniqueClientId = token.UniqueClientId,
                                    @seed = seed 
                            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            

            eventLog.Salir();
            return (response > 0);
        }*/
    }
}
