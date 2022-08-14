using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Recipes
{
    public class Likes
    {
        [Key]
        public long Id { get; set; }

        public double Result { get; set; }
        public long All { get; set; }
        public long Like { get; set; }

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