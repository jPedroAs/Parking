using Microsoft.EntityFrameworkCore;
using Parking.Domain.Models;

namespace Parking.Infra.Context;

public class ParkingContext : DbContext
{
    public DbSet<Register>? Registers { get; set; }
}