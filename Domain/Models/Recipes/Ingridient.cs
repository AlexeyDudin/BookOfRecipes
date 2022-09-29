using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class Ingridient
    {
        public long Id { get; set; }
        public virtual long RecipeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Products { get; set; }
    }
}