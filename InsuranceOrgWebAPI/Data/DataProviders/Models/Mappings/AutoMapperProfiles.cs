using AutoMapper;
using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Application.Mappings;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<DentalCoverageModel, DentalCoverageViewModel>()
            .ForMember(dest => dest.DentalCleaningAmount, opt => opt.MapFrom(src => src.DentalCleaningNumber));
        CreateMap<HealthCoverageModel, HealthCoverageViewModel>().ReverseMap();
    }
}