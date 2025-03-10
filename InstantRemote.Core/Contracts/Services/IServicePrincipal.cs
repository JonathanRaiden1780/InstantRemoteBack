using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServicePrincipal
    {
        List<GetConstEnrolaRsp> GetConstEnrola(int tipo);
        List<GetDispositivosResp> GetDispositivos(int emplid);
        List<GetDispositivoDetalleResp> GetDispositivoDetalle(string serie);

    }
}
