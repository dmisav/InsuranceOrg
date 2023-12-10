using System.Text;
using InsuranceOrgWebAPI.Application.Mappings;
using InsuranceOrgWebAPI.Common;
using InsuranceOrgWebAPI.Common.Authorization;
using InsuranceOrgWebAPI.Common.DependencyInjection;
using InsuranceOrgWebAPI.Common.Middlewares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.CustomOperationIds(e => $"{e.ActionDescriptor.RouteValues["action"]}");
    }
);
builder.Services.ConfigureOptions<ConfingureSwaggerOptions>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
DependencyMapper.RegisterDependencies(builder);
builder.Services.AddCors(options =>
{
    options.AddPolicy(Constants.CorsAllowSpecificOrigin,
        builder => builder.WithOrigins("http://localhost:5129/claims")
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    });
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddDefaultTokenProviders()
    .AddUserStore<InMemoryUserStore<IdentityUser>>()
    .AddRoleStore<InMemoryRoleStore<IdentityRole>>();


var app = builder.Build();

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

//TO DO
/*
 * add JWT authentication
 * Add UI project
 */

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
        }
    });
}
app.UseMiddleware<ActionExceptionHandlerMiddleware>();
app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "ImagesStore")),
    RequestPath = "/Images"
    // allows to Access static files from "http://localhost:5112/Images/d.jpg"
});
app.UseRouting();

app.UseCors(Constants.CorsAllowSpecificOrigin);

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();