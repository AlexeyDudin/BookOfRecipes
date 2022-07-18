using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Recipes
{
    public class Tags
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public List<RecipeTag> Recipes { get; set; }
    }
}