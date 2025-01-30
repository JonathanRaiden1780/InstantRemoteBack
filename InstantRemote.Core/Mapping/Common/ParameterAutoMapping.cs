using AutoMapper;


namespace InstantRemote.Core.Mapping.Common
{
    public class ParameterAutoMapping : Profile
    {
        public ParameterAutoMapping()
        {
            /*  CreateMap<ServiceConfigDto, ServiceReferenceDto>().ReverseMap()
                  .ForMember(dest => dest.Reference, a => a.MapFrom(src => $"{Constants.ReferenceVirtualDirectory}{Constants.Coma}{src.Reference}"))
                  .ForMember(dest => dest.Group, a => a.MapFrom(src => src.Group))
                  .ForMember(dest => dest.GroupProxy, a => a.MapFrom(src => src.ProxyGroup));

              CreateMap<InternalServicesDto, List<GetParameter>>().ReverseMap()
                  .ForMember(dest => dest.RootPath, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.RootPath))).Value))
                  .ForMember(dest => dest.VirtualDirectory, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.VirtualDirectory))).Value))
                  .ForMember(dest => dest.Endpoint, a => a.MapFrom(src => src.GetReferenceEndpoint()));

              CreateMap<CatalogDto, GetParameter>().ReverseMap();


              CreateMap<PublishDto, List<GetParameter>>().ReverseMap()
                  .ForMember(dest => dest.modo, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.Modo))).Value))
                  .ForMember(dest => dest.modoD, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.ModoD))).Value))
                  .ForMember(dest => dest.userid, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.Userid))).Value))
                  .ForMember(dest => dest.tarea, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.Tarea))).Value))
                  .ForMember(dest => dest.proyid, a => a.MapFrom(src => src.FirstOrDefault(x => x.Reference.Equals(nameof(References.Proyid))).Value));

              CreateMap<TransitDto, PublishDto>().ReverseMap()
                  .ForMember(dest => dest.expid, a => a.MapFrom(src => src.expid))
                  .ForMember(dest => dest.flujoid, a => a.MapFrom(src => src.tarea))
                  .ForMember(dest => dest.piid, a => a.MapFrom(src => src.proyid))
                  .ForMember(dest => dest.tipodocid, a => a.MapFrom(src => src.tipodocid))
                  .ForMember(dest => dest.userid, a => a.MapFrom(src => src.userid));


              CreateMap<TransitDto, FileTypeDetailDto>().ReverseMap()
                  .ForMember(dest => dest.flujoid, a => a.MapFrom(src => src.FlowId.ToString()))
                  .ForMember(dest => dest.procesoid, a => a.MapFrom(src => src.processId.ToString()))
                  .ForMember(dest => dest.piid, a => a.MapFrom(src => src.PIID.ToString()))
                  .ForMember(dest => dest.tareaid, a => a.MapFrom(src => src.taskId.ToString()))
                  .ForMember(dest => dest.tipodocid, a => a.MapFrom(src => src.TypeDocId));
  */
        }
    }
}
