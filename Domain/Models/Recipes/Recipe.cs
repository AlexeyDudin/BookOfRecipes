using Domain.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    [Table("Recipe")]
    public class Recipe
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("OwnerId")]
        public User Owner { get; set; }
        public string ShortInfo { get; set; }
        public List<RecipeTag> Tags { get; set; }
        public int TimeRemaining { get; set; }
        public int CountPersons { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        public List<Step> Steps { get; set; }

        public long OwnerId { get; set; }
    }
}
