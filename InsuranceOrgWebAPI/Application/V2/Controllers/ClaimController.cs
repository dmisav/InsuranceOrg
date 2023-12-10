using InsuranceOrgWebAPI.Application.CustomActionFilters;
using InsuranceOrgWebAPI.Application.DTO;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.V2.Controllers;

//[ApiController]
// disables this type of routing as bad practice which confuses swagger version json
//[Route("api/v2/[controller]/[action]")] 
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
    public IActionResult PostClaim([FromBody] ClaimViewModelV2 claim)
    {
        return Ok();
    }

    [HttpGet]
    [ActionName("GetProcessedClaims")]
    public IActionResult GetProcessedClaims()
    {
        var res = new ClaimViewModelV2()
        {
            Amount = 10,
            Date = DateTime.Now,
            Code = "xyz",
            DependantName = "son",
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