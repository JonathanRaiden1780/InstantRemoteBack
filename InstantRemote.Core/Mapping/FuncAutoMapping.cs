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

       /*     valor = endpoint.Reference switch
            {
             
                nameof(References.Authenticate) => endpoint.Value,
                nameof(References.GetProfile) => endpoint.Value,
                _ => throw new BusinessException(MessageServices.InvalidProcess),
            };*/

            return valor;
        }

    }
}
