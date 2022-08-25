using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirline.Entities;
namespace VoeAirline.EntityConfigurations;

public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
{
    public void Configure(EntityTypeBuilder<Manutencao> builder)
    {
      builder.ToTable("Manutencao");
      builder.HasKey(m=>m.Id);
      builder.Property(m=>m.DataHora)
            .IsRequired()
            .HasMaxLength(100);
      builder.Property(m=>m.Tipo)
             .IsRequired()
             .HasMaxLength(10);
      builder.HasIndex(m=>m.Observacoes)
             .IsUnique();
    }
}