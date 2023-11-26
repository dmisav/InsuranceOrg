using InsuranceOrgWebAPI.DataProviders;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class InsuranceCoverageController: ControllerBase
{
    private readonly ICoverageProvider _coverageProvider;
    private readonly ILogger<InsuranceCoverageController> _logger;

    public InsuranceCoverageController(ILogger<InsuranceCoverageController> logger, ICoverageProvider coverageProvider)
    {
        _coverageProvider = coverageProvider;
        _logger = logger;
    }

    public IActionResult GetDentalCoverage()
    {
        _coverageProvider.GetDentalCoverages();
        return Ok();
    }

    public IActionResult GetHealthCoverage()
    {
        //TO DO add automapper
        _coverageProvider.GetHealthCoverages();
        return Ok();
    }
}