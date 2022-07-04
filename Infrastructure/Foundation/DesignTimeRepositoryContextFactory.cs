using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Foundation
{
    public class DesignTimeRepositoryContextFactory : IDesignTimeDbContextFactory<TLRecipesDbContext>
    {
        public TLRecipesDbContext CreateDbContext( string[] args )
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
               .SetBasePath( Directory.GetCurrentDirectory() )
               .AddJsonFile( "appsettings.json" );

            var config = builder.Build();
            var connectionString = config.GetConnectionString( "Connection" );
            var optionsBuilder = new DbContextOptionsBuilder<TLRecipesDbContext>();
            optionsBuilder.UseSqlServer( connectionString );

            return new TLRecipesDbContext( optionsBuilder.Options );
        }
    }
}
