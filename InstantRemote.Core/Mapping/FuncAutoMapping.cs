using InstantRemote.Core.Helpers;
using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Mapping
{
    public static class FuncAutoMapping
    {
        public static string GetReferenceEndpoint(this List<GetParameter> parametros)
        {
            string valor = string.Empty;

            var endpoint = parametros.FirstOrDefault(x => !x.Referencia.Equals(Constants.ReferenceVirtualDirectory) && !x.Referencia.Equals(Constants.ReferenceRootPath));
            return valor;
        }

    }
}
