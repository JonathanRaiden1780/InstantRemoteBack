using AutoMapper;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Mapping.Common
{
    public class CommonAutoMapping : Profile
    {
        public CommonAutoMapping()
        {
            CreateMap<PermisosResponseDto, PermisosDrmResponseDto>().ReverseMap();
            CreateMap<GetSitesRespDto, GetSitesClienteRespDto>().ReverseMap()
                .ForMember(dest => dest.site, a => a.MapFrom(src => src.nameSite));
            CreateMap<GetSitesRespDto, GetSitesSucursalRespDto>().ReverseMap()
                .ForMember(dest => dest.ID_SITE, a => a.MapFrom(src => src.idSite))
                .ForMember(dest => dest.site, a => a.MapFrom(src => src.nameSite));
        }
    }
}
