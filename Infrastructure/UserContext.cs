using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users => Set<User>();
        public UserContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EVGENYA-PC;Initial Catalog=BooksOfRecipe;Integrated Security=True");
        }
    }
}
