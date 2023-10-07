using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking.API.Services;
using Parking.Application.ViewModels;

namespace Parking.API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly TokenService _tokenService; //Pablo isso aqui serve para gerar um dependência do obj
    public AccountController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("v1/accounts/register")]
    public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
    {
        return Ok();
    }

    //[AllowAnonymous]
    [HttpPost("v1/accounts/login")]
    public IActionResult Login()
    {
        var token = _tokenService.GenerationToken();

        return Ok(token);
    }
}
