using InsuranceOrgWebAPI.Application.DTO;
using InsuranceOrgWebAPI.Application.V1.Controllers;
using InsuranceOrgWebAPI.Data.DataProviders;
using InsuranceOrgWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace InsuranceOrg.Tests.TDD;

[TestFixture]
public class ClaimControllerTests : ControllerTestsBase
{
    private Mock<ILogger<ClaimController>> _loggerMock;
    private Mock<IClaimService> _claimServiceMock;
    private ClaimController sut;

    [SetUp]
    public void Setup()
    {
        _loggerMock = new Mock<ILogger<ClaimController>>();
        _claimServiceMock = new Mock<IClaimService>();
        sut = new ClaimController(_loggerMock.Object,_claimServiceMock.Object);
    }
    
    [Test]
    public void GetProcessedClaims_ReturnsOkResultWithClaimData()
    {
        // Act
        var result = sut.GetProcessedClaims() as ObjectResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);

        var claimData = result.Value as ClaimViewModelV1;
        Assert.IsNotNull(claimData);
    }

    [Test]
    public void GetPendingClaims_ReturnsOkResult()
    {
        // Act
        var result = sut.GetPendingClaims() as OkResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
    }
    
    [Test]
    public void PostClaim_ValidModel_ReturnsOkResult()
    {
        // Arrange
        var validClaim = new ClaimViewModelV1
        {
            Date = DateTime.Now,
            Type = ClaimType.Health,
            IssuerName = "Issuer",
            Code = "ABC",
            Amount = 100,
            OtherInfo = "Additional info"
        };

        // Set up mock behavior 
        _claimServiceMock.Setup(service => service.ProcessClaim(validClaim))
            .Returns(true);

        // Act
        var result = sut.PostClaim(validClaim) as OkResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        
        _claimServiceMock.Verify(service => service.ProcessClaim(validClaim), Times.Once);
    }
}
   