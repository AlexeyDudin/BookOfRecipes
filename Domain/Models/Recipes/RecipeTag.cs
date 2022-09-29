using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class RecipeTag
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual long RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public virtual Recipe Recipe { get; set; }
        public virtual long TagId { get; set; }
        [ForeignKey("TagId")]
        public virtual Tags Tag { get; set; }
    }
}
