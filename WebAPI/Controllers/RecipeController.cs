using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Dto.Recipes;
using WebAPI.Services.Recipe;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/recipe")]
    public class RecipeController : BaseController
    {
        private readonly IRecipeApiService _recipeApiService;

        public RecipeController(IRecipeApiService recipeApiService)
        {
            _recipeApiService = recipeApiService;
        }

        [HttpPost, Route("")]
        public IActionResult AddRecipe([FromBody] RecipeDto recipeDto)
        {
            return GetResponse(_recipeApiService.AddRecipe(recipeDto));
        }

        [HttpGet, Route("user")]
        public IActionResult GetUserRecipes([FromQuery] UserDto user)
        {
            return GetResponse(_recipeApiService.GetRecipeOfUser(user));
        }

        [AllowAnonymous]
        [HttpGet, Route("all")]
        public IActionResult GetAllRecipes()
        {
            return GetResponse(_recipeApiService.GetAllRecipes());
        }

        [HttpPost, Route("update")]
        public IActionResult UpdateRecipe([FromBody] RecipeDto recipeDto)
        {
            return GetResponse(_recipeApiService.ChangeRecipe(recipeDto));
        }

        [AllowAnonymous]
        [HttpGet, Route("top")]
        public IActionResult GetTopRecipe()
        {
            return GetResponse(_recipeApiService.GetTopRecipe());
        }

        [AllowAnonymous]
        [HttpPost, Route("byId")]
        public IActionResult GetRecipeById([FromBody] long recipeId)
        {
            return GetResponse(_recipeApiService.GetRecypeById(recipeId));
        }
    }
}
