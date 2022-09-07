using Domain.Foundation;
using Domain.Models.Recipes;
using Domain.Models.Users;

namespace Application.Recipes
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> _recipeService;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeService(IUnitOfWork repository)
        {
            _unitOfWork = repository;
            _recipeService = _unitOfWork.RecipeRepository;
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
            changedRecipe.RecipeTags = recipe.RecipeTags;
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

        public List<Recipe> GetAllRecipesOfUser(User user)
        {
            return (List<Recipe>)_recipeService.GetAll().Where(r => r.Owner == user);
        }

        public List<Recipe> GetByContainigName(string name)
        {
            return (List<Recipe>)_recipeService.GetAll().Where(r => r.Name.Contains(name));
        }

        public Recipe GetTopRecipe()
        {
            return _recipeService.GetAll().OrderByDescending(r => r.Likes.Result).FirstOrDefault();
        }
    }
}
