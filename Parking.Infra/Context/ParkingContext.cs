using Microsoft.EntityFrameworkCore;
using Parking.Domain.Entity;
using Parking.Infra.Mapping;

namespace Parking.Infra.Context;

public class ParkingContext : DbContext
{
    public ParkingContext(DbContextOptions<ParkingContext> options) : base(options)
    {
    }

    public virtual DbSet<Register>? Registers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.ApplyConfiguration(new RegisterMapping());
    }
}