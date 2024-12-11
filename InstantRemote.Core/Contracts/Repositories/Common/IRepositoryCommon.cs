using InstantRemote.Core.Dtos.Common.Request;

namespace InstantRemote.Core.Contracts.Repositories.Common
{
    public interface IRepositoryCommon
    {
        void InsertBitacoraInstantRemote (BitacoraRequestDto  bitacora);
        // string UpdatePassword(UpdatePasswordDto recuperar);
        // string ChangePassword(ChangePasswordDto cambio, string exid);

    }
}
