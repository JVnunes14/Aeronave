using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirline.Entities;
namespace VoeAirline.EntityConfigurations;

public class CancelamentoConfiguration : IEntityTypeConfiguration<Cancelamento>
{
    public void Configure(EntityTypeBuilder<Cancelamento> builder)
    {
      builder.ToTable("Cancelamento");
      builder.HasKey(c=>c.Id);
      builder.Property(c=>c.Motivo)
            .IsRequired()
            .HasMaxLength(100);
      builder.Property(c=>c.DataHoraNotificacao)
             .IsRequired();
    }
}