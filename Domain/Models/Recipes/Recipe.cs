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
        public virtual string Title { get; set; }
        
        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual string? DescriptionText { get; set; }

        public virtual List<RecipeTag> RecipeTags { get; set; }
        public virtual int TimeRemaining { get; set; }
        public virtual int CountPersons { get; set; }
        public virtual List<Ingridient> Ingridients { get; set; }
        public virtual List<Step> Steps { get; set; }
        public virtual ReceipePhoto Photo { get; set; }

        public virtual long OwnerId { get; set; }
        public virtual Likes Likes { get; set; }
    }
}
