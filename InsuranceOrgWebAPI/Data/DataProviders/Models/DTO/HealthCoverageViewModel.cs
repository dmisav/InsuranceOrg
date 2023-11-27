namespace InsuranceOrgWebAPI.Models;

public class HealthCoverageViewModel
{
    public int MaxCoverageAmount { get; set; }
    public Guid CustomerId { get; set; }
    public int MassageAllowanceAmount { get; set; }
    public int ChiropractorAllowanceAmunt { get; set; }
}