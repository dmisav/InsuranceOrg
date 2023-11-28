using InsuranceOrgWebAPI.DataProviders;
using InsuranceOrgWebAPI.Models;

namespace InsuranceOrgWebAPI.Data.DataProviders
{
    public class CoverageProviderRepository: ICoverageProvider
    {
        public async Task<IEnumerable<HealthCoverageModel>> GetHealthCoveragesAsync()
        {
            // let's imagine we are calling real storage in async way :)
            return HealthMockCollection;
        }

        public async Task<IEnumerable<DentalCoverageModel>> GetDentalCoveragesAsync()
        {
            // let's imagine we are calling real storage in async way :)
            return DentalMockCollection;
        }

        public IEnumerable<HealthCoverageModel>  GetHealthCoverages()
        {
            return HealthMockCollection;
        }

        public IEnumerable<DentalCoverageModel> GetDentalCoverages()
        {
            return DentalMockCollection;
        }
    
        private IEnumerable<HealthCoverageModel> HealthMockCollection
        {
            get
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
        }

        private IEnumerable<DentalCoverageModel> DentalMockCollection
        {
            get
            {
                return new List<DentalCoverageModel>()
                {
                    new DentalCoverageModel()
                    {
                        CustomerId = new Guid(),
                        DentalCleaningNumber = 100,
                        OrthodentalAmount = 20,
                        MaxCoverageAmount = 10
                    },
                    new DentalCoverageModel()
                    {
                        CustomerId = new Guid(),
                        DentalCleaningNumber = 30,
                        OrthodentalAmount = 40,
                        MaxCoverageAmount = 9
                    },
                    new DentalCoverageModel()
                    {
                        CustomerId = new Guid(),
                        DentalCleaningNumber = 80,
                        OrthodentalAmount = 20,
                        MaxCoverageAmount = 11
                    }
                };
            }
        }
    }
}