using InsuranceOrgWebAPI.DataProviders;

namespace InsuranceOrgWebAPI.DependencyInjection;

public static class DependencyMapper
{
    public static void RegisterDependencies(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICoverageProvider, CoverageProviderRepository>();
    }
}