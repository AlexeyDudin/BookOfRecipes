using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class RecipeTag
    {
        [Key]
        public long Id { get; set; }
        public long RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
        public long TagId { get; set; }
        [ForeignKey("TagId")]
        public Tags Tag { get; set; }
    }
}
