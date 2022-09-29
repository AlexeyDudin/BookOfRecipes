using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class PhotoConverter
    {
        public static ReceipePhoto ConvertRecipeFromDto(this RecipePhotoDto recipeDto)
        {
            ReceipePhoto recipePhoto = new ReceipePhoto();
            recipePhoto.Url = recipeDto.Url;
            recipePhoto.Name = recipeDto.Name;
            return recipePhoto;
        }

        public static RecipePhotoDto ConvertRecipeToDto(this ReceipePhoto recipe)
        {
            RecipePhotoDto recipeDto = new RecipePhotoDto();
            recipeDto.Url = recipe.Url;
            recipeDto.Name = recipe.Name;
            return recipeDto;
        }
    }
}
