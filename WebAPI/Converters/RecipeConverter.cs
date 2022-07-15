using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class RecipeConverter
    {
        public static Recipe ConvertRecipeFromDto( this RecipeDto recipeDto)
        {
            Recipe recipe = new Recipe();

            recipe.Name = recipeDto.Name;
            recipe.CountPersons = recipeDto.CountPersons;
            recipe.TimeRemaining = recipeDto.TimeRemaining;
            recipe.ShortInfo = recipeDto.ShortInfo;
            recipe.Tags = recipeDto.Tags.ConvertTagListFromDto();
            recipe.Steps = recipeDto.Steps.ConvertStepListFromDto();
            recipe.Owner = recipeDto.Owner.ConverUserFromDto();
            recipe.Ingridients = recipeDto.Ingridients.ConvertIngridientListFromDto();

            return recipe;
        }

        public static RecipeDto ConvertRecipeToDto(this Recipe recipe)
        {
            RecipeDto recipeDto = new RecipeDto();

            recipeDto.Name = recipeDto.Name;
            recipeDto.CountPersons = recipe.CountPersons;
            recipeDto.TimeRemaining = recipe.TimeRemaining;
            recipeDto.ShortInfo = recipe.ShortInfo;
            recipeDto.Tags = recipe.Tags.ConvertTagListToDto();
            recipeDto.Steps = recipe.Steps.ConvertStepListToDto();
            recipeDto.Owner = recipe.Owner.ConvertUserToDto();
            recipeDto.Ingridients = recipe.Ingridients.ConvertIngridientListToDto();

            return recipeDto;
        }
    }

    public static class TagConverter
    {
        public static List<Tags> ConvertTagListFromDto(this List<TagsDto> tagsDtos)
        {
            List<Tags> tags = new List<Tags>();

            foreach (TagsDto tagDto in tagsDtos)
            {
                tags.Add(new Tags { Name = tagDto.Name });
            }
            return tags;
        }

        public static List<TagsDto> ConvertTagListToDto(this List<Tags> tags)
        {
            List<TagsDto> result = new List<TagsDto>();

            foreach (Tags tag in tags)
            {
                result.Add(new TagsDto { Name = tag.Name });
            }
            return result;
        }
    }

    public static class StepConverter
    {
        public static List<Step> ConvertStepListFromDto(this List<StepDto> stepDtos)
        {
            List<Step> stepList = new List<Step>();

            foreach (StepDto stepDto in stepDtos)
            {
                stepList.Add(new Step
                {
                    Number = stepDto.Number,
                    Description = stepDto.Description,
                }
                            );
            }
            return stepList;
        }

        public static List<StepDto> ConvertStepListToDto(this List<Step> steps)
        {
            List<StepDto> stepDtos = new List<StepDto>();

            foreach (Step step in steps)
            {
                stepDtos.Add(new StepDto { Number = step.Number, Description = step.Description });
            }

            return stepDtos;
        }
    }

    public static class IngridientConverter
    {
        public static List<Ingridient> ConvertIngridientListFromDto(this List<IngridientDto> ingridientDtoList)
        {
            List<Ingridient> result = new List<Ingridient>();

            foreach (IngridientDto ingridientDto in ingridientDtoList)
            {
                result.Add(new Ingridient { Name = ingridientDto.Name, Products = ingridientDto.Products.ConvertProductListFromDto() });
            }

            return result;
        }

        public static List<IngridientDto> ConvertIngridientListToDto(this List<Ingridient> ingridientList)
        {
            List<IngridientDto> result = new List<IngridientDto>();

            foreach (Ingridient ingridient in ingridientList)
            {
                result.Add(new IngridientDto { Name = ingridient.Name, Products = ingridient.Products.ConvertProductListToDto() });
            }

            return result;
        }
    }

    public static class ProductsConverter
    {
        public static List<Product> ConvertProductListFromDto(this List<ProductDto> productDtoList)
        {
            List<Product> result = new List<Product>();

            foreach (ProductDto productDto in productDtoList)
            {
                result.Add(new Product { Name = productDto.Name });
            }

            return result;
        }

        public static List<ProductDto> ConvertProductListToDto(this List<Product> productList)
        {
            List<ProductDto> result = new List<ProductDto>();

            foreach (Product product in productList)
            {
                result.Add(new ProductDto { Name = product.Name });
            }

            return result;
        }
    }
}
