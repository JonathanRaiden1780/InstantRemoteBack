using AutoMapper;

namespace InstantRemote.Core.Mapping.Common
{
    public class CommonAutoMapping : Profile
    {
        public CommonAutoMapping()
        {
          /*  CreateMap<AddLoanRequestDto, QuoterDto>().ReverseMap()
                .ForMember(dest => dest.Group, a => a.MapFrom(src => nameof(GroupParameters.FREQUENCY_PAYMENT)))
                .ForMember(dest => dest.InsuranceAmount, a => a.MapFrom(src => src.Insurance.Price))
                .ForMember(dest => dest.InsuranceType, a => a.MapFrom(src => src.Insurance.Package))
                .ForMember(dest => dest.Reference, a => a.MapFrom(src => src.FrequencyPayment));
*/
            
        }
    }
}
