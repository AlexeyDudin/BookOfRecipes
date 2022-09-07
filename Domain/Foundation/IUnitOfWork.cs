using Domain.Models.Recipes;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Foundation
{
    public interface IUnitOfWork
    {
        public IRepository<Recipe> RecipeRepository { get; }

        public IRepository<User> UserRepository { get; }

        public void Commit();
    }
}
