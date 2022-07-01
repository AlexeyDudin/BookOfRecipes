namespace Domain.Recipes
{
    public class Ingridient
    {
        private int _id;
        private string _name;
        private List<Product> _products;

        public string Name { get => _name; set => _name = value; }
        public List<Product> Products { get => _products; set => _products = value; }
        public int Id { get => _id; set => _id = value; }
    }
}