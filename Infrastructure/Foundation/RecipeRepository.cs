using Domain.Foundation;
using Domain.Models.Recipes;

namespace Infrastructure.Foundation
{
    public class RecipeRepository : IRecipeRepository, IDisposable
    {
        private TLRecipesDbContext _dbContext;
        private IRepository<Recipe> _recipeRepository;

        public IRepository<Recipe> Repository { get { return _recipeRepository; } }

        public RecipeRepository(TLRecipesDbContext dbContext)
        { 
            _dbContext = dbContext;
            _recipeRepository = new Repository<Recipe>(dbContext);
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
