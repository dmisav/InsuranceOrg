using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.DataProviders;

public interface ICoverageProvider
{
    public Task<IEnumerable<HealthCoverageModel>> GetHealthCoveragesAsync();
    public Task<IEnumerable<DentalCoverageModel>> GetDentalCoveragesAsync();
}