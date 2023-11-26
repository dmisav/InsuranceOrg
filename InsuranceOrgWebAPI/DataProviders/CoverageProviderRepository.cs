using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.DataProviders;

public class CoverageProviderRepository: ICoverageProvider
{
    public IEnumerable<HealthCoverageModel>  GetHealthCoverages()
    {
        return new List<HealthCoverageModel>()
        {
            new HealthCoverageModel()
            {
                CustomerId = new Guid(),
                ChiropractorAllowanceAmunt = 100,
                MassageAllowanceAmount = 20,
                MaxCoverageAmount = 10
            },
            new HealthCoverageModel()
            {
                CustomerId = new Guid(),
                ChiropractorAllowanceAmunt = 30,
                MassageAllowanceAmount = 40,
                MaxCoverageAmount = 9
            },
            new HealthCoverageModel()
            {
            CustomerId = new Guid(),
            ChiropractorAllowanceAmunt = 80,
            MassageAllowanceAmount = 20,
            MaxCoverageAmount = 11
        }
        };
    }

    public IEnumerable<DentalCoverageModel> GetDentalCoverages()
    {
        return new List<DentalCoverageModel>()
        {
            new DentalCoverageModel()
            {
                CustomerId = new Guid(),
                DentalCleaningAmount = 100,
                OrthodentalAmount = 20,
                MaxCoverageAmount = 10
            },
            new DentalCoverageModel()
            {
                CustomerId = new Guid(),
                DentalCleaningAmount = 30,
                OrthodentalAmount = 40,
                MaxCoverageAmount = 9
            },
            new DentalCoverageModel()
            {
                CustomerId = new Guid(),
                DentalCleaningAmount = 80,
                OrthodentalAmount = 20,
                MaxCoverageAmount = 11
            }
        };
    }
}