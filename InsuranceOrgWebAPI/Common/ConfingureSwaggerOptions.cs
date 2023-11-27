using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace InsuranceOrgWebAPI.Common;

public class ConfingureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _apiVersionDescriptionProvider;
    public ConfingureSwaggerOptions(IApiVersionDescriptionProvider apiVersionDescriptionProvider)
    {
        _apiVersionDescriptionProvider = apiVersionDescriptionProvider;
    }

    public void Configure(string? name, SwaggerGenOptions options)
    {
        Configure(options);
    }

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var item in _apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(item.GroupName, CreateVersioInfo(item));
        }
    }

    private OpenApiInfo CreateVersioInfo(ApiVersionDescription description)
    {
        var info = new OpenApiInfo()
        {
            Title = "Versioned API",
            Version = description.ApiVersion.ToString()
        };
        return info;
    }
}
