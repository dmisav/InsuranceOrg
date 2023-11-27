using AutoMapper;
using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Application.Mappings;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<DentalCoverageModel, DentalCoverageViewModel>().ReverseMap();
        CreateMap<HealthCoverageModel, HealthCoverageViewModel>().ReverseMap();
    }
}