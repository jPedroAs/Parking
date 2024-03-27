using Microsoft.EntityFrameworkCore;
using Parking.Domain.Entity;

namespace Parking.Infra.Context;

public class ParkingContext : DbContext
{

    public virtual DbSet<Register>? Registers { get; set; }
}