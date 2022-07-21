using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{

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
}
