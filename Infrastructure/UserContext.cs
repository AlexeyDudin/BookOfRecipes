using Domain.Models.Users;
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

        public User? GetUserBy(string login, string passwd)
        {
            foreach (User user in this.Users)
            {
                if (user.Login == login && user.Password == passwd)
                    return user;
            }
            return null;
        }
    }
}
