using Domain.Models.Recipes;

namespace Application.Recipes
{
    public interface IRecipeService
    {
        Recipe Add(Recipe recipe);

        Recipe ChangeRecipe(Recipe recipe);
        List<Recipe> GetByContainigName(string name);
        List<Recipe> GetAllRecipes();
        Recipe GetTopRecipe();
    }
}
