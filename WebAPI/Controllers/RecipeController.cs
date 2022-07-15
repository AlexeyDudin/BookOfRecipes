using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Services.Recipe;

namespace WebAPI.Controllers
{
    [Route("api/recipes")]
    public class RecipeController : BaseController
    {
        private readonly IRecipeApiService _recipeApiService;

        public RecipeController(IRecipeApiService recipeApiService)
        {
            _recipeApiService = recipeApiService;
        }

        [HttpPost, Route("create")]
        public IActionResult AddRecipe([FromBody] RecipeDto recipeDto)
        {
            return GetResponse(_recipeApiService.AddRecipe(recipeDto));
        }

        [HttpGet, Route("{user}")]
        public IActionResult GetUserRecipes([FromBody] UserDto user)
        {
            return GetResponse(_recipeApiService.GetRecipeOfUser(user));
        }

        [HttpGet, Route("all")]
        public IActionResult GetAllRecipes()
        {
            return GetResponse(_recipeApiService.GetAllRecipes());
        }

        [HttpPost, Route("change")]
        public IActionResult ChangeRecipe([FromBody] RecipeDto recipeDto)
        {
            return GetResponse(_recipeApiService.ChangeRecipe(recipeDto));
        }
    }
}
