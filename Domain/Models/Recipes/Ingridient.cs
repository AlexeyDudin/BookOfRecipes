using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class Ingridient
    {
        public long Id { get; set; }
        public long RecipeId { get; set; }
        
        [ForeignKey("RecipeId")]
        public Recipe ParentRecipe { get; set; }
        public string Name { get; set; }
        public string Products { get; set; }
        //public List<Product> Products { get; set; }
        
    }
}