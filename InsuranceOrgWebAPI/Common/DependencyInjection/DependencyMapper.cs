using InsuranceOrgWebAPI.Data.DataProviders;
using InsuranceOrgWebAPI.DataProviders;

namespace InsuranceOrgWebAPI.Common.DependencyInjection;

public static class DependencyMapper
{
    public static void RegisterDependencies(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<ICoverageProvider, CoverageProviderRepository>();
    }
}