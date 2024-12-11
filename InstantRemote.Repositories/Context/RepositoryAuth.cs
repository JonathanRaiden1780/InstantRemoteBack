﻿using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.EntitiesStore.Common;
using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using InstantRemote.Core.Dtos.Common.Response;
using AutoMapper;
using System.Net;

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
    }
}
