using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Dto.Response;

namespace WebAPI.Services.Recipe
{
    public interface IRecipeApiService
    {
        Result GetAllRecipes();
        Result GetRecipeOfUser(UserDto user);
        Result AddRecipe(RecipeDto recipe);
        Result ChangeRecipe(RecipeDto recipe);

        Result GetRecipeByContainingName(string name);
    }
}
