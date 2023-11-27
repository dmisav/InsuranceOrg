using InsuranceOrgWebAPI.Application.CustomActionFilters;
using InsuranceOrgWebAPI.Application.DTO;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.V1.Controllers;

[ApiController]
[Route("api/v1/[controller]/[action]")]
public class ClaimController : ControllerBase
{
    private readonly ILogger<ClaimController> _logger;

    public ClaimController(ILogger<ClaimController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [ControllerValidateModel]
    [ActionName("PostClaim")]
    public IActionResult PostClaim([FromBody] ClaimViewModelV1 claim)
    {
        return Ok();
    }

    [HttpGet]
    [ActionName("GetProcessedClaims")]
    public IActionResult GetProcessedClaims()
    {
        var res = new ClaimViewModelV1()
        {
            Amount = 10,
            Date = DateTime.Now,
            Code = "xyz",
            IssuerName = "me",
            Type = ClaimType.Health,
            OtherInfo = "blah"
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