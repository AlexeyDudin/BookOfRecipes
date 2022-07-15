using Domain.Models.Recipes;

namespace Domain.Foundation
{
    public interface IRecipeRepository
    {
        public IRepository<Recipe> Repository { get; }

        public void Commit();
    }
}
