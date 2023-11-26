using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.DataProviders;

public interface ICoverageProvider
{
    public IEnumerable<HealthCoverageModel> GetHealthCoverages();
    public IEnumerable<DentalCoverageModel> GetDentalCoverages();
}