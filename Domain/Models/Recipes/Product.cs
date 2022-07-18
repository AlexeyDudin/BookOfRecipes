using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Recipes
{
    public class Product
    {
        public long Id { get; set; }
        public long IngridientId { get; set; }

        [ForeignKey("IngridientId")]
        public Ingridient ParentIngridient { get; set; }
        public string Name { get; set; }
    }
}