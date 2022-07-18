using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(rsf => rsf.Id);
            builder.Property(rsf => rsf.Id).HasColumnName("IngridientId");
            builder
                .HasOne(r => r.ParentIngridient)
                .WithMany(u => u.Products)
                .HasForeignKey(r => r.IngridientId);
        }
    }
}
