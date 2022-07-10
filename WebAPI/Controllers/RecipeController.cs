using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class RecipeController : BaseController
    {
        private readonly IRecipeApiService _recipeApiService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
