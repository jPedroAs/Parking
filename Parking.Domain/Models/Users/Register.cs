namespace Parking.Domain.Models;

public class Register : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}