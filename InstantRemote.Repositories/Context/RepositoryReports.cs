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
            var response = Connection.Query<LogAsistenciaResp>(StoreProcedure.IR_V2_RP_Log_Asistencia, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<RetardosResp> GetRetardos (FiltrosRepReq filtro)
        {
            var response = Connection.Query<RetardosResp>(StoreProcedure.IR_V2_RP_Retardos_Admin, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<HuerfanosResp> GetHuerfanos (FiltroHuerfanos filtro)
        {
            var response = Connection.Query<HuerfanosResp>(StoreProcedure.IR_V2_RP_Huerfanos, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<GetReportesClientes> GetReportClientes (int emplid)
        {
            var response = Connection.Query<GetReportesClientes>(StoreProcedure.sp_ReporteCliente, new{emplid}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<GetReportesEnrolados> GetReportEdoEnrola (FiltroEdoEnrola filtro)
        {
            var responses = Connection.Query<GetReportesEnrolados>(StoreProcedure.IR_V2_RP_Enrolados_filtro, filtro, commandType: CommandType.StoredProcedure).ToList();
            return responses;
        } 
        public List<GetReportesHrsExtras> GetReportHrsExtra (FiltroHrsExtra filtro)
        {
            var response = Connection.Query<GetReportesHrsExtras>(StoreProcedure.IR_V2_RP_Asistencia_Estandar_Hrs_Extras, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
        public List<GetReportAsistenciaAnual> GetReportAsistenciaAnual(FiltroAsistenciaAnual filtro)
        {
            var response = Connection.Query<GetReportAsistenciaAnual>(StoreProcedure.IR_V2_RP_Asistencia_Estandar_por_Anio, filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        } 
      
    }
}
