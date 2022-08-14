namespace WebAPI.Dto.Recipes
{
    public class IngridientDto
    {
        public string Name { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}