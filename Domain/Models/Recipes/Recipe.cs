using Domain.Models.Users;

namespace Domain.Models.Recipes
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public string ShortInfo { get; set; }
        public List<Tags> Tags { get; set; }
        public int TimeRemaining { get; set; }
        public int CountPersons { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        public List<Step> Steps { get; set; }
    }
}
