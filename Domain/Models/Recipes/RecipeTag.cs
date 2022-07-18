using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Recipes
{
    public class RecipeTag
    {
        [Key]
        public long Id { get; set; }
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public long TagId { get; set; }
        public Tags Tag { get; set; }
    }
}
