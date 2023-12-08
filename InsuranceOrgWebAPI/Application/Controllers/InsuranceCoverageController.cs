using AutoMapper;
using InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]/[action]")]
[ApiVersion("1.0")]
[ApiVersion("2.0")]
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
    [MapToApiVersion("1.0")]
    public async Task<IEnumerable<DentalCoverageViewModel>> GetDentalCoverageV1()
    {
        var coverages = await _coverageProvider.GetDentalCoveragesAsync();
        return _mapper.Map<IEnumerable<DentalCoverageViewModel>>(coverages);
    }
    
    [HttpGet]
    [ActionName("GetDentalCoverage")]
    [MapToApiVersion("2.0")]
    public async Task<IEnumerable<DentalCoverageViewModel>> GetDentalCoverageV2()
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
    [MapToApiVersion("1.0")]
    public async Task<IEnumerable<HealthCoverageViewModel>> GetHealthCoverage()
    {
        var coverages = await _coverageProvider.GetHealthCoveragesAsync();
        return _mapper.Map<IEnumerable<HealthCoverageViewModel>>(coverages);
    }
    
    [HttpGet]
    [ActionName("GetMimicException")]
    [MapToApiVersion("1.0")]
    public OkResult GetMimicException()
    {
        throw new Exception("Oh no!");
    }
}