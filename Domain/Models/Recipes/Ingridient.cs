using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class Ingridient
    {
        public long Id { get; set; }
        public virtual long RecipeId { get; set; }
        
        [ForeignKey("RecipeId")]
        public virtual Recipe ParentRecipe { get; set; }
        public virtual string Name { get; set; }
        public virtual string Products { get; set; }
        //public List<Product> Products { get; set; }
        
    }
}