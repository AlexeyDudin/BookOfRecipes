using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Dto.Response;
using Application.Recipes;
using WebAPI.Converters;
using Application.Recipes.Exceptions;
using Domain.Models.Recipes;
using Domain.Models.Users;

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
                List<RecipeDto> result = new List<RecipeDto>();
                foreach (Domain.Models.Recipes.Recipe recipe in _recipeService.GetAllRecipes())
                {
                    result.Add(recipe.ConvertRecipeToDto());
                }
                return new Result(result, ResponseStatus.Ok);
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
                List<RecipeDto> result = new List<RecipeDto>();
                foreach (Domain.Models.Recipes.Recipe recipe in _recipeService.GetAllRecipesOfUser(user.ConverUserFromDto()))
                {
                    result.Add(recipe.ConvertRecipeToDto());
                }
                return new Result(result, ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetRecipeByContainingName(string name)
        {
            try
            {
                List<RecipeDto> result = new List<RecipeDto>();
                foreach (Domain.Models.Recipes.Recipe recipe in _recipeService.GetByContainigName(name))
                {
                    result.Add(recipe.ConvertRecipeToDto());
                }
                return new Result(result, ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetTopRecipe()
        {
            try
            {
                return new Result(_recipeService.GetTopRecipe().ConvertRecipeToDto(), ResponseStatus.Ok);
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
                return new Result(_recipeService.GetRecypeById(id).ConvertRecipeToDto(), ResponseStatus.Ok);
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
