using AutoMapper;


namespace InstantRemote.Core.Mapping.Common
{
    public class EntitiesAutoMapping : Profile
    {
        public EntitiesAutoMapping()
        {
            //Primero es el destino y despues origen           

        /*    CreateMap<User, SearchCustomerDto>().ReverseMap()
               .ForMember(dest => dest.Nickname, a => a.MapFrom(src => src.Rfc))
               .ForMember(dest => dest.Password, a => a.MapFrom(src => $"{src.Curp}{SecurityManager.RandomString}".Encrypt()));
            */

        }
    }
}
