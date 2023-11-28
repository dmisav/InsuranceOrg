using InsuranceOrgWebAPI.Application.DTO;

namespace InsuranceOrgWebAPI.Data.DataProviders;

public class ClaimService : IClaimService
{
    public bool ProcessClaim(ClaimViewModelV1 claim)
    {
        return true;
    }
}