using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class TagConverter
    {
        public static List<RecipeTag> ConvertTagListFromDto(this List<TagsDto> tagsDtos)
        {
            List<RecipeTag> tags = new List<RecipeTag>();

            foreach (TagsDto tagDto in tagsDtos)
            {
                tags.Add(new RecipeTag { Tag = new Tags { Name = tagDto.Name } });
                //tags.Add(new RecipeTag { Name = tagDto.Name });
            }
            return tags;
        }

        public static List<TagsDto> ConvertTagListToDto(this List<RecipeTag> tags)
        {
            List<TagsDto> result = new List<TagsDto>();

            foreach (RecipeTag tag in tags)
            {
                result.Add(new TagsDto { Name = tag.Tag.Name });
            }
            return result;
        }
    }
}
