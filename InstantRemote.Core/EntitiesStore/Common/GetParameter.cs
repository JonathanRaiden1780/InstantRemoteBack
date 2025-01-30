namespace InstantRemote.Core.EntitiesStore.Common
{
    public class GetParameter
    {
        public string Referencia { get; set; }
        public string Valor { get; set; }
    }
    
    public class GetEstados
    {
        public string id_edo { get; set; }
        public string estado { get; set; }
    }
    
    public class GetMunicipio
    {
        public string id_mun { get; set; }
        public string municipio { get; set; }
    }
    
    public class GetColonia
    {
        public string id_col { get; set; }
        public string colonia { get; set; }
    }
    
    public class GetCP
    {
        public string id_CP { get; set; }
        public string CP { get; set; }
    }
    public class GetZonaHoraria
    {
        public string id { get; set; }
        public string descripcion { get; set; }
    }
    
}
