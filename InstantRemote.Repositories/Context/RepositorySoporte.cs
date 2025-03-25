using System.Data;
using InstantRemote.Core.EntitiesStore.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Contracts.Repositories.Common;
using Dapper;
using AutoMapper;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Repositories.Context
{
    public class RepositorySoporte : BaseRepository, IRepositorySoporte
    {
        public RepositorySoporte(IDbConnection connection, Func<IDbTransaction> transaction,IDbConnection connectionSQL, Func<IDbTransaction> transactionSQL, IMapper mapper) : base(
            connection, transaction, connectionSQL,transactionSQL, mapper)
        {
        }
        
        public List<GetRegSms> GetRegSms(GetRegSmsReq req)
        {
            var response = ConnectionSQL.Query<GetRegSms>(StoreProcedure.sp_getRegistrosSMS, req, commandType: CommandType.StoredProcedure).ToList();
            return response;        
        }
        public List<GetRegTel> GetRegTel(string req)
        {
            var response = ConnectionSQL.Query<GetRegTel>(StoreProcedure.IR_V2_RP_RegistrosTelefonicos, new {dispositivo = req}, commandType: CommandType.StoredProcedure).ToList();
            return response;        
        }
        public List<GetPass> GetPass(string req)
        {
            var query = "select convert(varchar, t.numEmpleado) as usuario,t.nombre,t.status,t.site,t.desDepto,l.pass from tblLoguinInicio l join tblEmpleados t on t.numEmpleado=l.usuario where usuario='"+ req + "'";
            return Connection.Query<GetPass>(query, commandType: CommandType.Text).ToList();
        }
        public List<GetAltasMan> GetAltasMan()
        {
            var response = ConnectionSQL.Query<GetAltasMan>(StoreProcedure.IR_V2_RP_Altas_Manuales, new {numEmpleado = ""}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetBitComMan> GetBitComMan(string fechaIni, string fechaFin)
        {
            var response = Connection.Query<GetBitComMan>(StoreProcedure.sp_GetBitacoraMovimientos, new {fechaIni = fechaIni, fechaFin= fechaFin }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
    }
}
