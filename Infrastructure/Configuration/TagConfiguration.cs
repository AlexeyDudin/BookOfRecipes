using Domain.Models.Recipes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.ToTable(nameof(Ingridient));
            builder.HasKey(rsf => rsf.Id);
            builder.Property(rsf => rsf.Id).HasColumnName("TagId");
        }
    }
}
