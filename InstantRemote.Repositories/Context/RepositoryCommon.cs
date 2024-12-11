using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using AutoMapper;
using Dapper;

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
                                + bitacora.Accion + "," 
                                + bitacora.Descripcion + ","
                                + bitacora.Tipo + ",GETDATE(),'')";

           var x = Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault();

        }


    }
}
