using System.ComponentModel.DataAnnotations;
using InsuranceOrgWebAPI.Models;

namespace InsuranceOrg.UI.Data;

public class ClaimViewModelV1
{
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public ClaimType Type { get; set; }
    [Required]
    public string? IssuerName { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "Code is minimum 3 characters")]
    [MaxLength(10, ErrorMessage = "Code is maximum 10 characters")]
    public string Code { get; set; }
    [Required]
    public int Amount { get; set; }
    public string? OtherInfo { get; set; }
}

public class ClaimViewModelV2
{
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public ClaimType Type { get; set; }
    [Required]
    public string? DependantName { get; set; }
    [MinLength(3, ErrorMessage = "Code is minimum 3 characters")]
    [MaxLength(10, ErrorMessage = "Code is maximum 10 characters")]
    public string? Code { get; set; }
    [Required]
    public int Amount { get; set; }
    public string? OtherInfo { get; set; }
}