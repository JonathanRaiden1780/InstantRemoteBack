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
    public class RepositoryReports : BaseRepository, IRepositoryReports
    {
        public RepositoryReports(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(connection, transaction, mapper)
        {
        }
        
        public List<LogAsistenciaResp> GetLogAsistencia (FiltrosReq filtro)
        {
            var result = Connection.Query(StoreProcedure.IR_V2_RP_Log_Asistencia, filtro, commandType: CommandType.StoredProcedure);
            var response = Connection.Query<LogAsistenciaResp>(StoreProcedure.IR_V2_RP_Log_Asistencia, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<RetardosResp> GetRetardos (FiltrosReq filtro)
        {
            var result = Connection.Query(StoreProcedure.IR_V2_RP_Retardos_Admin, filtro, commandType: CommandType.StoredProcedure);
            var response = Connection.Query<RetardosResp>(StoreProcedure.IR_V2_RP_Retardos_Admin, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
      
    }
}
