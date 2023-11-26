using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.DataProviders;

public interface ICoverageProviders
{
    public IEnumerable<HealthCoverageModel> GetHealthCoverages();
    public IEnumerable<DentalCoverageModel> GetDentalCoverageModel();
}