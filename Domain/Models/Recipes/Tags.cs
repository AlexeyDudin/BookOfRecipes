using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Recipes
{
    public class Tags
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<RecipeTag> Recipes { get; set; }
    }
}