using System.Net;
using System.Security.Policy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Parking.API.Services;
using Parking.Application.ViewModels;
using Parking.Domain.Entity;
using Parking.Infra.Context;

namespace Parking.API.Controllers;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly ParkingContext _parkingContext;
    private readonly TokenService _tokenService; //Pablo isso aqui serve para gerar um dependência do obj
    private readonly PasswordHash _hash;
    public AccountController(TokenService tokenService, PasswordHash hash)
    {
        _tokenService = tokenService;
        _hash = hash;
    }

    [HttpPost("v1/accounts/register")]
    public async Task<ResponseViewModel> Register([FromBody]RegisterViewModel model)
    {
        var response = new ResponseViewModel();
        try{
        var pass = _hash.HashPassword(model.Password);

        var resgister = new Register{
            Name = model.Name,
            Email = model.Email,
            Password = pass,
            Birthday = model.Birthday
        };

        await 
        
        return response.GetResponse("Registrado com sucesso.", HttpStatusCode.OK);
        } 
        catch
        {
            return response.GetResponse("Ocorreu um Error.", HttpStatusCode.BadRequest);
        }
    }

    //[AllowAnonymous]
    [HttpPost("v1/accounts/login")]
    public async Task<ResponseViewModel> Login()
    {
        var response = new ResponseViewModel();
        var token =  _tokenService.GenerationToken();

       return response.GetResponse("Registrado com sucesso.", HttpStatusCode.OK);
    }
}
