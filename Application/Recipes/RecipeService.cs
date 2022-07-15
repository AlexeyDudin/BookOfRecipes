using Domain.Foundation;
using Domain.Models.Recipes;

namespace Application.Recipes
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> _recipeService;
        private readonly IRecipeRepository _unitOfWork;

        public RecipeService(IRecipeRepository repository)
        {
            _unitOfWork = repository;
            _recipeService = _unitOfWork.Repository;
        }

        public Recipe Add(Recipe recipe)
        {
            _recipeService.Add(recipe);
            _unitOfWork.Commit();
            return recipe;
        }

        public Recipe ChangeRecipe(Recipe recipe)
        {
            Recipe changedRecipe = _recipeService.FirstOrDefault(e => (e.Owner == recipe.Owner && e.Name == recipe.Name));
            changedRecipe.ShortInfo = recipe.ShortInfo;
            changedRecipe.TimeRemaining = recipe.TimeRemaining;
            changedRecipe.Tags = recipe.Tags;
            changedRecipe.Steps = recipe.Steps;
            changedRecipe.Ingridients = recipe.Ingridients;
            changedRecipe.CountPersons = recipe.CountPersons;
            
            _unitOfWork.Commit();

            return recipe;
        }

        public List<Recipe> GetAllRecipes()
        {
            return _recipeService.GetAll();
        }

        public List<Recipe> GetByContainigName(string name)
        {
            return (List<Recipe>)_recipeService.GetAll().Where(r => r.Name.Contains(name));
        }
    }
}
