using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryPrincipal
    {
        List<GetDispositivosResp> GetDispositivos(int emplid);
        List<GetConstEnrolaRsp> GetConstEnrola(int tipo);
        List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie);
    }
}
