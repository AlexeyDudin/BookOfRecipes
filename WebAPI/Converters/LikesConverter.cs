using Domain.Models.Recipes;
using WebAPI.Dto.Recipes;

namespace WebAPI.Converters
{
    public static class LikesConverter
    {
        public static Likes ConvertLikesFromDto(this long likeCount)
        {
            Likes likes = new Likes();
            likes.Like = likeCount;
            return likes;
        }

        public static long ConvertLikesToDto(this Likes likes)
        {
            return likes.Like;
        }
    }
}
