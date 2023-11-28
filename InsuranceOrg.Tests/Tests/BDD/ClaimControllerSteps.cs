using InsuranceOrgWebAPI.Application.DTO;
using InsuranceOrgWebAPI.Application.V1.Controllers;
using InsuranceOrgWebAPI.Data.DataProviders;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using TechTalk.SpecFlow;

namespace InsuranceOrg.Tests.BDD;
//To run use terminal and "dotnet test"
[Binding]
public class ClaimControllerSteps
{
    private ClaimController _claimController;
    private Mock<ILogger<ClaimController>> _loggerMock;
    private Mock<IClaimService> _claimServiceMock;
    private ClaimViewModelV1 _claim;
    private IActionResult _result;

    [Given("a valid claim with details")]
    public void GivenAValidClaimWithDetails()
    {
        _claim = new ClaimViewModelV1
        {
            Date = DateTime.Now,
            Type = ClaimType.Health,
            IssuerName = "Issuer",
            Code = "ABC",
            Amount = 100,
            OtherInfo = "Additional info"
        };
    }

    [When("I post the claim")]
    public void WhenIPostTheClaim()
    {
        _loggerMock = new Mock<ILogger<ClaimController>>();
        _claimServiceMock = new Mock<IClaimService>();
        _claimServiceMock.Setup(service => service.ProcessClaim(_claim))
            .Returns(true);

        _claimController = new ClaimController(_loggerMock.Object, _claimServiceMock.Object);
        _result = _claimController.PostClaim(_claim);
    }

    [Then("the response should indicate success")]
    public void ThenTheResponseShouldIndicateSuccess()
    {
        Assert.IsNotNull(_result);
        Assert.IsInstanceOf<OkResult>(_result);
        Assert.AreEqual(200, ((OkResult)_result).StatusCode);

        _claimServiceMock.Verify(service => service.ProcessClaim(_claim), Times.Once);
    }
}