using Microsoft.AspNetCore.Mvc;

namespace Parking.API.Controllers.User;

[ApiController]
public class UserController: ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(string op)
    {
        return Ok(op);
    }
}