using InstantRemote.Core.EntitiesStore.Common;

namespace InstantRemote.Core.Helpers
{
    public static class Parameters
    {
        public static string ObtenerValor(this List<GetParameter> parameters, string reference)
               => parameters.FirstOrDefault(x => x.Referencia.Equals(reference)).Valor;
    }
}
