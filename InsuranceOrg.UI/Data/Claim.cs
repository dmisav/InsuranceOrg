namespace InsuranceOrg.UI.Data;

public class Claim
{
    public DateTime Date { get; set; }
    public int Type { get; set; }
    public string IssuerName { get; set; }
    public string Code { get; set; }
    public decimal Amount { get; set; }
    public string OtherInfo { get; set; }
}