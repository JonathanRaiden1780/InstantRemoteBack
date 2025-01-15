using System.Data;
using InstantRemote.Core.EntitiesStore.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Contracts.Repositories.Common;
using Dapper;
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
            var query = "SELECT Referencia, Valor FROM [dbo].[parametrosIR] WHERE IsActive = 1 AND  Referencia = @reference";
            var respuesta = Connection.Query<GetParameter>(query, new  {@reference= reference},commandType: CommandType.Text).FirstOrDefault();
            return respuesta;
        }
        
        public List<GetEstados> GetEstados()
        {
            var query = "select id_edo,estado from catEstadoSepo";
            var respuesta = Connection.Query<GetEstados>(query, commandType: CommandType.Text).ToList();
            return respuesta;
        }
        
        public List<GetMunicipio> GetMunicipio(int estado)
        {
            var query = "select id_mun,UPPER(municipio) as municipio from catMunicipioSepo where id_edo = @estado";
            return Connection.Query<GetMunicipio>(query, new { @estado = estado }).ToList();

        }
        
        public List<GetColonia> GetColonia(int estado, int mun)
        {
            var query = "select id_col,UPPER(colonia) as colonia from catColoniaSepo where id_edo = @estado and id_mun = @municipio";
            return Connection.Query<GetColonia>(query, new { @estado = estado, @municipio = mun }).ToList();

        }
        
        public List<GetCP> GetCP(int estado, int mun, int col)
        {
            var query = "select id_CP,CP from catCPSepo where id_edo = @estado and id_mun = @municipio and id_col = @colonia";
            return Connection.Query<GetCP>(query, new { @estado = estado, @municipio = mun, @colonia=col }).ToList();

        }
        
        public List<GetZonaHoraria> GetZonaHoraria()
        {
            var query = "  select idZonaH as id ,UPPER(descripcion) as descripcion from  catZonaHoraria with (nolock) union select 5,'ZONA CENTRO 0'";
            return  Connection.Query<GetZonaHoraria>(query, commandType: CommandType.Text).ToList();

        }
      
    }
}
