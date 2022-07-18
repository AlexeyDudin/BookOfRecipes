using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class RecipeTagConfiguration : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder
                .HasOne(r => r.Recipe)
                .WithMany(u => u.Tags)
                .HasForeignKey(sc => sc.RecipeId);
            builder
                .HasOne(r => r.Tag)
                .WithMany(u => u.Recipes)
                .HasForeignKey(tg => tg.TagId);
        }
    }
}
