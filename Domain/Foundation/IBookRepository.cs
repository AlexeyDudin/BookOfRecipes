using Domain.Models.Recipes;
using Domain.Models.Users;

namespace Domain.Foundation
{
    public interface IBookRepository
    {
        public IRepository<Recipe> RecipeRepository { get; }

        public IRepository<User> UserRepository { get; }

        public void Commit();
    }
}
