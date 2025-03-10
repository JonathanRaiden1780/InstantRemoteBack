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
        public RepositoryPrincipal(IDbConnection connection, Func<IDbTransaction> transaction,IDbConnection connectionSQL, Func<IDbTransaction> transactionSQL, IMapper mapper) : base(
            connection, transaction, connectionSQL,transactionSQL, mapper)
        {
        }
        
        public List<GetConstEnrolaRsp> GetConstEnrola(int tipo)
        {
            var response = Connection.Query<GetConstEnrolaRsp>(StoreProcedure.IR_V2_RP_ConstantesEnrolados, new
            {
                @numEmpleado = "",
                @tipo = tipo
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }

        public List<GetDispositivosResp> GetDispositivos(int emplid)
        {
            var response = ConnectionSQL.Query<GetDispositivosResp>(StoreProcedure.sp_GetDispositivos, new
            {
                @emplid = emplid
            }, commandType: CommandType.StoredProcedure,commandTimeout:120).ToList();
            return response;
        }
        
        public List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie)
        {
            var response = ConnectionSQL.Query<GetDispositivoDetalleResp>(StoreProcedure.sp_GetEmpleadosPorDispositivo, new
            {
                @serie = serie
            }, commandType: CommandType.StoredProcedure).ToList();
            return response;
        }
    }
}