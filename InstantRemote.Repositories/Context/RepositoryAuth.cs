using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using Dapper;
using InstantRemote.Core.Dtos.Common.Response;
using AutoMapper;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryAuth : BaseRepository, IRepositoryAuth
    {
        public RepositoryAuth(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {

        }

        public PermisosResponseDto Login(SingInReqDto signIn)
        {
            var username = signIn.Username;
            var password = signIn.Password;
            var query = "SELECT COUNT(*) FROM tblLoguinInicio WHERE email = '" + username + "' and pass = '" + password + "'";
            var response = int.Parse(Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault());
            if (response > 0)
            {
                var identUser = IdentUser(username);
                var permisoVariables = GetpermisoAutorizarVariables(username);
                var permisosUser = GetUserPermiso(username);
                var user = mapper.Map<PermisosResponseDto>(permisosUser);
                user.Nombre = identUser.nombre.Trim();
                user.Variables = permisoVariables;
                return user;
            }
            else
            {
                throw new Exception("Usuario o contraseña incorrecto. Intente de nuevo por favor.");
            }

        }

        public IdentEmpleadoDto IdentUser(string emplid)
        {
            var query = "SELECT numEmpleado,nombre FROM tblEmpleados WHERE numEmpleado =" + emplid;
            var response = Connection.Query<IdentEmpleadoDto>(query, commandType: CommandType.Text).FirstOrDefault();
            return response;
        }

        public bool GetpermisoAutorizarVariables(string emplid)
        {
            string query = "select COUNT(*) from variables where [idBum/Kam] = '" + emplid + "' or idSubdirector='" + emplid+ "' or idDireccionOperaciones='" + emplid + "' or [IdDireccionP&C] ='" + emplid + "'";
            var response = int.Parse(Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault());
            var permiso = response > 0 ? true : false; 
            return permiso;
        }
        public PermisosDrmResponseDto GetUserPermiso(string emplid)
        {

            string query = "select COUNT(*) from permisosDRM_V2 where numEmpleado = " + emplid;
            var responseCount = int.Parse(Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault());
            PermisosDrmResponseDto response = new PermisosDrmResponseDto();
            if (responseCount > 0)
            {
                query = "select * from permisosDRM_V2 where numEmpleado = " + emplid;
                response = Connection.Query<PermisosDrmResponseDto>(query, commandType: CommandType.Text).FirstOrDefault();
            }

            return response;
        }
        public GetTokenRespDto GetTokenStatus(int emplid)
        {
            GetTokenRespDto response = new GetTokenRespDto();
            var query = "select numEmpleado, TokenID, estado, Tipo from dbo.tblToken01 where numEmpleado =" + emplid;
            response=Connection.Query<GetTokenRespDto>(query, commandType: CommandType.Text).FirstOrDefault();
            if (response == null)
            {
                response = new GetTokenRespDto();
            }
            return response;
        }

        public EmpleadoMailRespDto ValidEmail(int emplid)
        {
            var query = "select [CORREO-E] as mail, [NOMBRE COMPLETO] as name from dbo.correos210823 where [NUMERO EMPLEADO] = " + emplid;
            return Connection.Query<EmpleadoMailRespDto>(query, commandType: CommandType.Text).FirstOrDefault();
        }

        public bool UpdatePassword(ChangePassReqDto newData)
        {
            var query = "UPDATE tblLoguinInicio SET pass = @Password WHERE usuario = @UserId";
            var affectedRows = Connection.Execute(query, new { Password = newData.Password, UserId = newData.UserId });
            return affectedRows > 0;
        }
    }
}
