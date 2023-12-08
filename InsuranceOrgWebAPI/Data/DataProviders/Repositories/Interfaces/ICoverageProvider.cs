using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;

public interface ICoverageProvider
{
    public Task<IEnumerable<HealthCoverageModel>> GetHealthCoveragesAsync();
    public Task<IEnumerable<DentalCoverageModel>> GetDentalCoveragesAsync();
}