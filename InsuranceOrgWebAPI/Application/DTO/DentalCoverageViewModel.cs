namespace InsuranceOrgWebAPI.Models;

public class DentalCoverageViewModel
{
    public int MaxCoverageAmount { get; set; }
    public Guid CustomerId { get; set; }
    public int DentalCleaningAmount { get; set; }
    public int OrthodentalAmount { get; set; }
}