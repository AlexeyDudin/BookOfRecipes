using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User));
            builder.HasKey(rsf => rsf.Id);
            builder.HasIndex(r => r.Login).IsUnique(true);
            builder.Property(rsf => rsf.Id).HasColumnName("UserId");
        }
    }
}
