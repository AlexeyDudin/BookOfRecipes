using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Recipes
{
    public class Likes
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual double Result { get; set; }
        public virtual long All { get; set; }
        public virtual long Like { get; set; }

        public void AddLike()
        {
            Like++;
            All++;
            Result = Like / All;
        }

        public void AddDislike()
        {
            All++;
            Result = Like / All;
        }
    }
}