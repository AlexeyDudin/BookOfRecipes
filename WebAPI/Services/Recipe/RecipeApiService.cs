using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Dto.Response;
using Application.Recipes;

namespace WebAPI.Services.Recipe
{
    public class RecipeApiService : IRecipeApiService
    {
        private readonly IRecipeService _recipeService;

        public RecipeApiService(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public Result AddRecipe(RecipeDto recipe)
        {
            throw new NotImplementedException();
        }

        public Result ChangeRecipe(RecipeDto recipe)
        {
            throw new NotImplementedException();
        }

        public Result GetAllRecipes()
        {
            throw new NotImplementedException();
        }

        public Result GetRecipeOfUser(UserDto user)
        {
            throw new NotImplementedException();
        }
    }
}
