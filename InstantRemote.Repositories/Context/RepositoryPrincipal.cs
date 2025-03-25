using InstantRemote.Core.Contracts.Repositories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using System.Data;
using AutoMapper;
using Dapper;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.Helpers;

namespace InstantRemote.Repositories.Context
{
    public class RepositoryPrincipal : BaseRepository, IRepositoryPrincipal
    {
        public RepositoryPrincipal(IDbConnection connection, Func<IDbTransaction> transaction, IDbConnection connectionSQL, Func<IDbTransaction> transactionSQL, IMapper mapper) : base(
            connection, transaction, connectionSQL, transactionSQL, mapper)
        {
        }

        #region Constantes y Enrolados
        public List<GetConstEnrolaRsp> GetConstEnrola(int tipo)
        {
            var response = Connection.Query<GetConstEnrolaRsp>(StoreProcedure.IR_V2_RP_ConstantesEnrolados, new { @numEmpleado = "", @tipo = tipo }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        #endregion
        #region Devices
        public List<GetDispositivosResp> GetDispositivos(int emplid)
        {
            var response = ConnectionSQL.Query<GetDispositivosResp>(StoreProcedure.sp_GetDispositivos, new { @emplid = emplid }, commandType: CommandType.StoredProcedure, commandTimeout: 120).ToList();
            return response;
        }

        public List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie)
        {
            var response = ConnectionSQL.Query<GetDispositivoDetalleResp>(StoreProcedure.sp_GetEmpleadosPorDispositivo, new { @serie = serie }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        #endregion
        #region Horas Extras
        public List<GetSolHrsExtras> GetSolHrsExtras(string emplid)
        {
            var response = ConnectionSQL.Query<GetSolHrsExtras>(StoreProcedure.sp_getRegistrosHrasExtras, new { @emplid = emplid }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetSolHrsExtrasDetalle> GetSolHrsExtrasDetalle(string id)
        {
            var response = ConnectionSQL.Query<GetSolHrsExtrasDetalle>(StoreProcedure.sp_getRegistrosHrasExtrasDetalle, new { @id = id }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetSolHrsExtrasAll> GetSolHrsExtrasAll()
        {
            var response = ConnectionSQL.Query<GetSolHrsExtrasAll>(StoreProcedure.IR_V2_SP_Get_AllSolicitudesHrasExtras,new{emplid=0}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public string CaducarVigencia(CaducarVigenciaReq request)
        {
            var response = ConnectionSQL.Query<string>(StoreProcedure.uspGuardaVigencia, request, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public string QuitarVigencia(CaducarVigenciaReq request)
        {
            var response = ConnectionSQL.Query<string>(StoreProcedure.uspQuitarVigencia, request, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public List<GetEmpleadoInfo> GetInfoName(string emplid)
        {
            var response = Connection.Query<GetEmpleadoInfo>(StoreProcedure.sp_InfoNameEmpleado, new { emplid = emplid }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public string ValidaCalendar(string desde)
        {
            var response = ConnectionSQL.Query<string>(StoreProcedure.sp_validaCalendario, new { desde = desde, empleado = "", retorno = "0"}, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public string SaveHrsExtra(SaveSolicitudHrsReq request)
        {
            var response = ConnectionSQL.Query<string>(StoreProcedure.sp_guardaSolicitudHrasExtras, request, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        public List<GetAutHrsExtras> GetAutHrsExtras(string emplid)
        {
            var response = ConnectionSQL.Query<GetAutHrsExtras>(StoreProcedure.sp_getSolicitudesParaAutorizarHrasExtras, new {emplid=emplid}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public string AutHrsExtras(AutHrsExtrasReq request)
        {
            var response = ConnectionSQL.Query<string>(StoreProcedure.sp_AutorizarHrasExtras, request, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return response;
        }
        #endregion

        #region Autorizar Variables
        public List<AutVarInd> GetAutVarInd(string emplid)
        {
            var response = Connection.Query<AutVarInd>(StoreProcedure.sp_GetDetalleVariableInd, new{emplid=emplid}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<AutVarInd> GetAutVarJer(string emplid)
        {
            var response = Connection.Query<AutVarInd>(StoreProcedure.sp_GetDetalleVariableJerar, new{emplid=emplid}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public List<GetVarAut> GetVarAutorizar(string numeroEmpleado, string calendario)
        {
            var response = Connection.Query<GetVarAut>(StoreProcedure.sp_GetVariablesAutorizar, new{numeroEmpleado=numeroEmpleado,calendario=calendario}, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
        public void AutVariable(AutVarReq req)
        {
            Connection.Query<GetVarAut>(StoreProcedure.sp_UpdateStatusVariable, req, commandType: CommandType.StoredProcedure);
        }

        public string GetVigencia (string cal)
        {
            var query = "SELECT DISTINCT Caducada FROM variables WHERE Periodo='" + cal+ "'";
            return Connection.Query<string>(query, commandType: CommandType.Text).FirstOrDefault();
        }

        public string VigenciaVar(VigenciaVarReq req)
        {
            return Connection.Query<string>(StoreProcedure.uspGuardaVigenciaVariables, req, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
        public List<GetConcepto> GetConcepto ()
        {
            var query = "select idConcepto,Concepto,Elemento from catConceptoVariable";
            return Connection.Query<GetConcepto>(query, commandType: CommandType.Text).ToList();
        }
        public void UpdateVar(UpdateVarReq req)
        {
            Connection.Query<string>(StoreProcedure.IR_V2_SP_UpdateConceptoImporteVariables, req, commandType: CommandType.StoredProcedure);
        }
        #endregion
    }
}