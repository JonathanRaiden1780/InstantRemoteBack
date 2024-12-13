

using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Contracts.Services
{
    public interface IServiceFiltros
    {
        List<GetCatZonaClientesRespDto> GetCatZonaClientes (string emplid);
       
    }
}
