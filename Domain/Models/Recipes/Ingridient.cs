namespace Domain.Models.Recipes
{
    public class Ingridient
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public int Id { get; set; }
    }
}