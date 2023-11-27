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
    public IEnumerable<DentalCoverageViewModel> GetDentalCoverage()
    {
        var coverages = _coverageProvider.GetDentalCoverages();
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
    public IActionResult GetHealthCoverage()
    {
        //TO DO add automapper
        _coverageProvider.GetHealthCoverages();
        return Ok();
    }
}