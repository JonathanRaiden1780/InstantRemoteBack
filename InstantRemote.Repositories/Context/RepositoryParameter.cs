using System;
using System.Data;
using System.Collections.Generic;
using InstantRemote.Core.EntitiesStore.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Contracts.Repositories.Common;
using Dapper;
using InstantRemote.Core.Helpers;
using System.Linq;
using AutoMapper;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryParameter : BaseRepository, IRepositoryParameter
    {
        public RepositoryParameter(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {
        }

      

        public GetParameter GetParameter(ParameterDto parameter)
        {
            var query = "SELECT Referencia, Valor FROM [dbo].[parametrosIR] WHERE Grupo = '" + parameter.Group + "' AND Referencia = '" + parameter.Reference +"'";
            var respuesta = Connection.Query<GetParameter>(query, commandType: CommandType.Text).FirstOrDefault();
            return respuesta;
        }

        public List<GetParameter> GetParametersByGroup(string group)
        {
            var query = "SELECT Referencia, Valor FROM [dbo].[parametrosIR] WHERE IsActive = 1 AND  Grupo = '"+ group + "'";
            var respuesta = Connection.Query<GetParameter>(query, commandType: CommandType.Text).AsList();
            return respuesta;
        }

        public GetParameter GetParameterById(int idParameter)
        {
            var query = "SELECT Referencia, Valor FROM [dbo].[parametrosIR] WHERE IsActive = 1 AND  Id =" + idParameter;
            var respuesta = Connection.Query<GetParameter>(query, commandType: CommandType.Text).FirstOrDefault();
            return respuesta;
        }

        public GetParameter GetParameterByReference(string reference)
        {
            var query = "SELECT Referencia, Valor FROM [dbo].[parametrosIR] WHERE IsActive = 1 AND  Referencia =" + reference;
            var respuesta = Connection.Query<GetParameter>(query, commandType: CommandType.Text).FirstOrDefault();
            return respuesta;
        }
    }
}
