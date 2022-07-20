namespace Domain.Models.Recipes
{
    public class Likes
    {
        private long all;
        private long likes;
        public double Result { get; set; }

        public void AddLike()
        {
            likes++;
            all++;
            Result = likes / all;
        }

        public void AddDislike()
        {
            all++;
            Result = likes / all;
        }
    }
}