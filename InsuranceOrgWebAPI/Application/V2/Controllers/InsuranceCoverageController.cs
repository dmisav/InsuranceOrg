using AutoMapper;
using InsuranceOrgWebAPI.DataProviders;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class InsuranceCoverageController: ControllerBase
{
    private readonly ICoverageProvider _coverageProvider;
    private readonly IMapper _mapper;
    private readonly ILogger<InsuranceCoverageController> _logger;

    public InsuranceCoverageController(
        ILogger<InsuranceCoverageController> logger, 
        ICoverageProvider coverageProvider,
        IMapper mapper
        )
    {
        _coverageProvider = coverageProvider;
        _mapper = mapper;
        _logger = logger;
    }
    
    [HttpGet]
    [ActionName("GetDentalCoverage")]
    public async Task<IEnumerable<DentalCoverageViewModel>> GetDentalCoverage()
    {
        var coverages = await _coverageProvider.GetDentalCoveragesAsync();
        return _mapper.Map<IEnumerable<DentalCoverageViewModel>>(coverages);
    }
    /*
    //[HttpGet]
    //[Route("{id:Guid}")]
    public IActionResult GetDentalCoverageById([FromBody]Guid id)
    {
        _coverageProvider.GetDentalCoverages();
        return Ok();
    }
    */
    [HttpGet]
    [ActionName("GetHealthCoverage")]
    public async Task<IEnumerable<HealthCoverageViewModel>> GetHealthCoverage()
    {
        var coverages = await _coverageProvider.GetHealthCoveragesAsync();
        return _mapper.Map<IEnumerable<HealthCoverageViewModel>>(coverages);
    }
    
    [HttpGet]
    [ActionName("GetMimicException")]
    public OkResult GetMimicException()
    {
        throw new Exception("Oh no!");
    }
}