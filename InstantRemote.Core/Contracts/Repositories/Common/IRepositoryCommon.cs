using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryCommon
    {
        void InsertBitacoraInstantRemote (BitacoraRequestDto  bitacora);
        List<GetCatZonaClientesRespDto> GetCatZonaClientes(string emplid, string parameter);


    }
}
