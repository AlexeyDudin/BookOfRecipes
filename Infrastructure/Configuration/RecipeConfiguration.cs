using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable(nameof(Recipe));
            builder.HasKey(rsf => rsf.Id);
            builder.Property(rsf => rsf.Id).HasColumnName("RecipeId");
            builder
                .HasOne(r => r.Owner)
                .WithMany(u => u.Recipes)
                .HasForeignKey(r => r.OwnerId);

        }
    }
}
