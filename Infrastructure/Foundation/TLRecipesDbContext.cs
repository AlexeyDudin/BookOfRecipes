using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Foundation
{
    public class TLRecipesDbContext : DbContext
    {
        public TLRecipesDbContext( DbContextOptions<TLRecipesDbContext> dbContextOptions )
            :base( dbContextOptions )
        { }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            builder.ApplyConfiguration( new UserConfiguration() );
        }
    }
}
