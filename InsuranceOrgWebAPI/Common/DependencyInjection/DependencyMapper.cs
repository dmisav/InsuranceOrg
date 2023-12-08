using InsuranceOrgWebAPI.Data.DataProviders;
using InsuranceOrgWebAPI.Data.DataProviders.Repositories;
using InsuranceOrgWebAPI.Data.DataProviders.Repositories.Interfaces;

namespace InsuranceOrgWebAPI.Common.DependencyInjection;

public static class DependencyMapper
{
    public static void RegisterDependencies(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<ICoverageProvider, CoverageProviderRepository>();
        builder.Services.AddScoped<IClaimService, ClaimService>();
        builder.Services.AddScoped<IImageUploadRepository, LocalSystemImageRepository>();
    }
}