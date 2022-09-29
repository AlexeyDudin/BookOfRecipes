using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class RecipeConverter
    {
        public static Recipe ConvertRecipeFromDto( this RecipeDto recipeDto)
        {
            Recipe recipe = new Recipe();
            recipe.Id = recipeDto.Id;
            recipe.Title = recipeDto.Title;
            recipe.CountPersons = recipeDto.CountPersons;
            recipe.TimeRemaining = recipeDto.TimeRemaining;
            recipe.DescriptionText = recipeDto.DescriptionText;
            recipe.RecipeTags = recipeDto.Tags.ConvertTagListFromDto();
            recipe.Steps = recipeDto.Steps.ConvertStepListFromDto();
            recipe.Owner = recipeDto.Owner.ConverUserFromDto();
            recipe.Ingridients = recipeDto.Ingridients.ConvertIngridientListFromDto();
            recipe.Likes = recipeDto.LikeCount.ConvertLikesFromDto();
            recipe.Photo = recipeDto.RecipePhoto.ConvertRecipeFromDto();
            return recipe;
        }

        public static RecipeDto ConvertRecipeToDto(this Recipe recipe)
        {
            RecipeDto recipeDto = new RecipeDto();
            recipeDto.Id = recipe.Id;
            recipeDto.Title = recipeDto.Title;
            recipeDto.CountPersons = recipe.CountPersons;
            recipeDto.TimeRemaining = recipe.TimeRemaining;
            recipeDto.DescriptionText = recipe.DescriptionText;
            recipeDto.Tags = recipe.RecipeTags.ConvertTagListToDto();
            recipeDto.Steps = recipe.Steps.ConvertStepListToDto();
            recipeDto.Owner = recipe.Owner.ConvertUserToDto();
            recipeDto.Ingridients = recipe.Ingridients.ConvertIngridientListToDto();
            recipeDto.LikeCount = recipe.Likes.ConvertLikesToDto();
            recipeDto.RecipePhoto = recipe.Photo.ConvertRecipeToDto();
            return recipeDto;
        }
    }
}
