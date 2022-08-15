using Domain.Foundation;
using Domain.Models.Recipes;
using Domain.Models.Users;

namespace Infrastructure.Foundation
{
    public class BookRepository : IBookRepository, IDisposable
    {
        private TLRecipesDbContext _dbContext;
        private IRepository<Recipe> _recipeRepository;
        private IRepository<User> _userRepository;

        public IRepository<Recipe> RecipeRepository { get { return _recipeRepository; } }
        public IRepository<User> UserRepository { get { return _userRepository; } }

        public BookRepository(TLRecipesDbContext dbContext)
        {
            _dbContext = dbContext;
            _recipeRepository = new Repository<Recipe>(dbContext);
            _userRepository = new Repository<User>(dbContext);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
