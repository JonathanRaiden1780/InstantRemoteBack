using AutoMapper;
using InstantRemote.Core.Dtos.Common.Response;

namespace InstantRemote.Core.Mapping.Common
{
    public class CommonAutoMapping : Profile
    {
        public CommonAutoMapping()
        {
            CreateMap<PermisosResponseDto, PermisosDrmResponseDto>().ReverseMap();


        }
    }
}
