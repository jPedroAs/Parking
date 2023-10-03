using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Parking.API.Autentication;

namespace Parking.API.Services;

public class TokenService
{
    public string GenerationToken()
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Configuartion.JwtKey);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Expires = DateTime.UtcNow.AddHours(8),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), 
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token =tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}