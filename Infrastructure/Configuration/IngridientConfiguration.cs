using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class IngridientConfiguration : IEntityTypeConfiguration<Ingridient>
    {
        public void Configure(EntityTypeBuilder<Ingridient> builder)
        {
            builder.ToTable(nameof(Ingridient));
            builder.HasKey(rsf => rsf.Id);
            builder.Property(rsf => rsf.Id).HasColumnName("IngridientId");
        }
    }
}
