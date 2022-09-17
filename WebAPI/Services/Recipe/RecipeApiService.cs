using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Dto.Response;
using Application.Recipes;
using WebAPI.Converters;
using Application.Users.Exceptions;

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
            try
            {
                return new Result(_recipeService.Add(RecipeConverter.ConvertRecipeFromDto(recipe)), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result ChangeRecipe(RecipeDto recipe)
        {
            try
            {
                return new Result(_recipeService.ChangeRecipe(recipe.ConvertRecipeFromDto()), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetAllRecipes()
        {
            try
            {
                return new Result(_recipeService.GetAllRecipes(), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetRecipeOfUser(UserDto user)
        {
            try
            {
                return new Result(_recipeService.GetAllRecipesOfUser(user.ConverUserFromDto()), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
            //TODO
            throw new NotImplementedException("Нужно реализовать GetRecipeOfUser в RecipeApiService");
        }

        public Result GetRecipeByContainingName(string name)
        {
            //TODO
            throw new NotImplementedException("Нужно реализовать GetRecipeOfUser в RecipeApiService");
        }

        public Result GetTopRecipe()
        {
            try
            {
                return new Result(_recipeService.GetTopRecipe(), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetRecypeById(long id)
        {
            try
            {
                return new Result(_recipeService.GetRecypeById(id), ResponseStatus.Ok);
            }
            catch (RecipeNotFoundException ex)
            {
                return new Result(ex.Message, ResponseStatus.RecipeNotFound);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }
    }
}
