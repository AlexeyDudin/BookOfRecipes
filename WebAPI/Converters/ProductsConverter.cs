using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
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
