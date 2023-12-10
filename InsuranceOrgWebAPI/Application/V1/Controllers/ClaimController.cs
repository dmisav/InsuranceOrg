using InsuranceOrgWebAPI.Application.CustomActionFilters;
using InsuranceOrgWebAPI.Application.DTO;
using InsuranceOrgWebAPI.Data.DataProviders;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.V1.Controllers;

[ApiController]
[Route("api/v1/[controller]/[action]")]
public class ClaimController : ControllerBase
{
    private readonly ILogger<ClaimController> _logger;
    private readonly IClaimService _claimService;

    public ClaimController(ILogger<ClaimController> logger, IClaimService claimService)
    {
        _logger = logger;
        _claimService = claimService;
    }

    [HttpPost]
    [ControllerValidateModel]
    [ActionName("PostClaim")]
    public IActionResult PostClaim([FromBody] ClaimViewModelV1 claim)
    {
        _claimService.ProcessClaim(claim);
        return Ok();
    }

    [HttpGet]
    [ActionName("GetProcessedClaims")]
    public IActionResult GetProcessedClaims()
    {
        ClaimViewModelV1[] res = {
            new() {
            Amount = 10,
            Date = DateTime.Now,
            Code = "xyz",
            IssuerName = "me",
            Type = ClaimType.Health,
            OtherInfo = "blah" },
            new() {
                Amount = 11,
                Date = DateTime.Now,
                Code = "abc",
                IssuerName = "someone",
                Type = ClaimType.Health,
                OtherInfo = "blah"}
        };
        return Ok(res);
    }

    [HttpGet]
    [ActionName("GetPendingClaims")]
    public IActionResult GetPendingClaims()
    {
        return Ok();
    }

}