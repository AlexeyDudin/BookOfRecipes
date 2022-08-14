using Domain.Models.Recipes;
using Domain.Models.Users;

namespace Application.Recipes
{
    public interface IRecipeService
    {
        Recipe Add(Recipe recipe);

        Recipe ChangeRecipe(Recipe recipe);
        List<Recipe> GetByContainigName(string name);
        List<Recipe> GetAllRecipes();
        Recipe GetTopRecipe();
        List<Recipe> GetAllRecipesOfUser(User user);
    }
}
