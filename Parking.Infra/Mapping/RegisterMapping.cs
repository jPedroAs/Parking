using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parking.Domain.Models;

namespace Parking.Infra.Mapping;

public class RegisterMapping : IEntityTypeConfiguration<Register>
{
    public void Configure(EntityTypeBuilder<Register> builder)
    {
        builder.ToTable("Registers", "bancoFicaAqui");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(250);
        builder.Property(p => p.Password).IsRequired().HasMaxLength(250);
    }
}