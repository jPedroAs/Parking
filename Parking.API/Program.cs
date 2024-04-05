using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Parking.API.TokenServices;
using Parking.API.TokenServices;
using Parking.Infra.Context;

var builder = WebApplication.CreateBuilder(args);

var key = Encoding.ASCII.GetBytes(Configuartion.JwtKey);
builder.Services.AddAuthentication(x => 
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x => {
    x.TokenValidationParameters = new TokenValidationParameters{
        ValidateIssuerSigningKey = true, 
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, 
        ValidateAudience = false
    };
});

builder.Services.AddDbContext<ParkingContext>((option) => {
    option.UseSqlServer("Server=localhost;Database=Parking;User ID=sa;Password=Nina123;Trusted_Connection=False; TrustServerCertificate=True;");
});

builder.Services.AddControllers();

builder.Services.AddTransient<TokenService>();


var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
