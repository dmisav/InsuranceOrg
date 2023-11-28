using InsuranceOrgWebAPI.Application.DTO;

namespace InsuranceOrgWebAPI.Data.DataProviders;

public interface IClaimService
{
    bool ProcessClaim(ClaimViewModelV1 claim);
}