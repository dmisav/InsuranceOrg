using InsuranceOrgWebAPI.Common.Authorization;
using InsuranceOrgWebAPI.Data.DataProviders.Models.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceOrgWebAPI.Application.Controllers;

[ApiController]
[Route("api[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;

    public AuthController(UserManager<IdentityUser> userManager)
    {
        
        _userManager = userManager;
    }

    [HttpPost]
    [Route("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
    {
        var identityUser = new IdentityUser()
        {
            UserName = registerRequestDto.Username,
            Email = registerRequestDto.Username
        };
        var identityResult = await _userManager.CreateAsync(identityUser, registerRequestDto.Password);
        if (identityResult.Succeeded)
        {
            if (registerRequestDto.Roles != null & registerRequestDto.Roles.Any())
            {
                identityResult = await _userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);
                if (identityResult.Succeeded)
                {
                    return Ok("User was registered! Please login.");
                }
            }
        }
        return BadRequest("Insufficient Roles");
    }
}