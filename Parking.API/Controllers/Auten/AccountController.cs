using System.Security.Policy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking.API.Services;
using Parking.Application.ViewModels;

namespace Parking.API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly TokenService _tokenService; //Pablo isso aqui serve para gerar um dependência do obj
    private readonly PasswordHash _hash;
    public AccountController(TokenService tokenService, PasswordHash hash)
    {
        _tokenService = tokenService;
        _hash = hash;
    }

    [HttpPost("v1/accounts/register")]
    public async Task<IActionResult> Register([FromBody]RegisterViewModel model)
    {
        var pass = _hash.HashPassword(model.Password);
        
        return Ok();
    }

    //[AllowAnonymous]
    [HttpPost("v1/accounts/login")]
    public async Task<IActionResult> Login()
    {
        var token =  _tokenService.GenerationToken();

        return Ok(token);
    }
}
