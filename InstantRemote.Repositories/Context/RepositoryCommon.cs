using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using AutoMapper;
using Dapper;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryCommon : BaseRepository, IRepositoryCommon
    {
        public RepositoryCommon(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {

        }

        public void InsertBitacoraInstantRemote(BitacoraRequestDto bitacora)
        {
            var query = "INSERT INTO tblBitacoraInstanRemote values ('" 
                                + bitacora.Usuario + "' ,'" 
                                + bitacora.Accion + "','" 
                                + bitacora.Descripcion + "','"
                                + bitacora.Pantalla + "',GETDATE(),'')"; 
            Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault();
        }

        public List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter)
        {
            var query = "select idZonaCliente as id ,nomCliente as cliente from  catZonaCliente with (nolock)";
            if (parameter != null)
                query += "where idZonaCliente in (" + parameter + ")";

            query += "order by idZonaCliente";

            return Connection.Query<GetCatZonaClientesRespDto>(query, commandType: CommandType.Text).ToList();
        }

    }
}
