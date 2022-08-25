using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirline.Entities;
namespace VoeAirline.EntityConfigurations;

public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
{
    public void Configure(EntityTypeBuilder<Aeronave> builder)
    {
      builder.ToTable("Aeronaves");
      builder.HasKey(a=>a.Id);
      builder.Property(a=>a.Fabricante)
            .IsRequired()
            .HasMaxLength(100);
      builder.Property(a=>a.Modelo)
             .IsRequired()
             .HasMaxLength(40);
      builder.Property(a=>a.Codigo)
             .IsRequired()
             .HasMaxLength(25);
      builder.Property(a=>a.Celebridade)
             .IsRequired()
             .HasMaxLength(40); 
      builder.HasMany(a=>a.Manutencoes)
             .WithOne(m=>m.Aeronave)
             .HasForeignKey(m=>m.AeronaveId);
    }
}

