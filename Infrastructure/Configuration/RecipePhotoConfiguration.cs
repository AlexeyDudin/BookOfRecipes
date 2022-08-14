using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class RecipePhotoConfiguration : IEntityTypeConfiguration<ReceipePhoto>
    {
        public void Configure(EntityTypeBuilder<ReceipePhoto> builder)
        {
            builder.ToTable(nameof(ReceipePhoto));
            builder.HasKey(rsf => rsf.Id);
            builder.Property(rsf => rsf.Id).HasColumnName("RecipePhotoId");
        }
    }
}
