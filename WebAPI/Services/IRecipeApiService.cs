using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Dto.Response;

namespace WebAPI.Services
{
    public interface IRecipeApiService
    {
        Result GetAllRecipes();
        Result GetRecipeOfUser(UserDto user);
        Result AddRecipe(UserDto user, RecipeDto recipe);
        Result ChangeRecipe(RecipeDto recipe);
    }
}
