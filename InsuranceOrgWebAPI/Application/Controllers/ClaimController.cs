using InsuranceOrgWebAPI.Application.CustomActionFilters;
using InsuranceOrgWebAPI.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
    public IActionResult PostClaim([FromBody] ClaimViewModel claim)
    {
        return Ok();
    }

    [HttpGet]
    [ActionName("GetProcessedClaims")]
    public IActionResult GetProcessedClaims()
    {
        return Ok();
    }

    [HttpGet]
    [ActionName("GetPendingClaims")]
    public IActionResult GetPendingClaims()
    {
        return Ok();
    }

}