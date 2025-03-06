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
        public RepositoryReports(IDbConnection connection, Func<IDbTransaction> transaction, IMapper mapper) : base(
            connection, transaction, mapper)
        {
        }

        public List<LogAsistenciaResp> GetLogAsistencia(FiltrosReq filtro)
        {
            var response = Connection.Query<LogAsistenciaResp>(StoreProcedure.IR_V2_RP_Log_Asistencia, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<RetardosResp> GetRetardos(FiltrosRepReq filtro)
        {
            var response = Connection.Query<RetardosResp>(StoreProcedure.IR_V2_RP_Retardos_Admin, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<HuerfanosResp> GetHuerfanos(FiltroHuerfanos filtro)
        {
            var response = Connection.Query<HuerfanosResp>(StoreProcedure.IR_V2_RP_Huerfanos, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportesClientes> GetReportClientes(int emplid)
        {
            var response = Connection.Query<GetReportesClientes>(StoreProcedure.sp_ReporteCliente, new {emplid},
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportesEnrolados> GetReportEdoEnrola(FiltroEdoEnrola filtro)
        {
            var responses = Connection.Query<GetReportesEnrolados>(StoreProcedure.IR_V2_RP_Enrolados_filtro, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return responses;
        }

        public List<GetReportesHrsExtras> GetReportHrsExtra(FiltroHrsExtra filtro)
        {
            var response = Connection
                .Query<GetReportesHrsExtras>(StoreProcedure.IR_V2_RP_Asistencia_Estandar_Hrs_Extras, filtro,
                    commandType: CommandType.StoredProcedure,commandTimeout: 240).ToList() ;
            return response;
        }

        public List<GetReportAsistenciaAnual> GetReportAsistenciaAnual(FiltroAsistenciaAnual filtro)
        {
            var response = Connection
                .Query<GetReportAsistenciaAnual>(StoreProcedure.IR_V2_RP_Asistencia_Estandar_por_Anio, filtro,
                    commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsistenciaAnualResumen> GetReportAsistenciaAnualResumen(
            FiltroAsistenciaAnualResumen filtro)
        {
            var response = Connection.Query<GetReportAsistenciaAnualResumen>(
                StoreProcedure.IR_V2_RP_Asistencia_Estandar_por_Anio_Resumen, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsistenciaEstandar> GetReportAsistenciaEstandar(FiltroAsistenciaAnualResumen filtro)
        {
            var response = Connection.Query<GetReportAsistenciaEstandar>(StoreProcedure.IR_V2_RP_Asistencia_Estandar,
                filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAcumuladoAsistencia> GetReportAcumuladoAsistencia(FiltroAsistenciaAcumulado filtro)
        {
            var response = Connection.Query<GetReportAcumuladoAsistencia>(StoreProcedure.IR_V2_RP_Acumulado_Asistencia,
                filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAusentismos> GetReportAusentismos(FiltroAusentismos filtro)
        {
            var response = Connection.Query<GetReportAusentismos>(StoreProcedure.IR_V2_RP_Ausentismos, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsistencia> GetReportAsistencia(FiltroAsistencia filtro)
        {
            var response = Connection.Query<GetReportAsistencia>(StoreProcedure.IR_V2_RP_Asistencia, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsistenciaTemp> GetReportAsistenciaTemperatura(FiltroAsistencia filtro)
        {
            var response = Connection.Query<GetReportAsistenciaTemp>(StoreProcedure.IR_V2_RP_Asistencia_Temperatura,
                filtro, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportApp> GetReportApp(FiltroApp filtro)
        {
            var response = Connection.Query<GetReportApp>(StoreProcedure.IR_V2_RP_Track_App, filtro,
                commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsignaciones> GetReportAsignaciones(string numEmpleado)
        {
            var response = Connection.Query<GetReportAsignaciones>(StoreProcedure.IR_V2_RP_AsignacionesTemporales,
                new {numEmpleado = numEmpleado}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetReportAsignaciones> GetReportAsignacionesAll()
        {
            var response = Connection.Query<GetReportAsignaciones>(StoreProcedure.IR_V2_RP_AsignacionesTemporalesAll,
                 commandType: CommandType.StoredProcedure,commandTimeout:120).ToList();
            return response;
        }

        public List<GetReportMatriz> GetReportMatrizApro(FiltroMatriz filtro)
        {
            var response = Connection.Query<GetReportMatriz>(StoreProcedure.sp_GetVariablesMatrizAprobacion, filtro,
                 commandType: CommandType.StoredProcedure, commandTimeout:120).ToList();
            return response;
        }
        public List<GetReportCapturaManual> GetReportCapturaManual(string filtro)
        {
            var response = Connection.Query<GetReportCapturaManual>(StoreProcedure.IR_V2_SP_chequeosManualesDetalle, new{idCalSemanal = filtro},
                 commandType: CommandType.StoredProcedure, commandTimeout:120).ToList();
            return response;
        }
        public List<GetReportAsistenciaTempAll> GetReportAsistenciaTemperaturaAll(FiltroAsistencia filtro)
        {
            var response = Connection.Query<GetReportAsistenciaTempAll>(StoreProcedure.IR_V2_RP_Asistencia_Temperatura_All_Days,   filtro,
                 commandType: CommandType.StoredProcedure, commandTimeout:120).ToList();
            return response;
        }
    }

}
