using Domain.Foundation;
using Domain.Models.Recipes;
using Domain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Foundation
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private TLRecipesDbContext _dbContext;
        private IRepository<Recipe> _recipeRepository;
        private IRepository<User> _userRepository;

        public IRepository<Recipe> RecipeRepository { get { return _recipeRepository; } }

        public IRepository<User> UserRepository { get { return _userRepository; } }

        public UnitOfWork(TLRecipesDbContext dbContext)
        {
            _dbContext = dbContext;
            _recipeRepository = new Repository<Recipe>(dbContext);
            _userRepository = new Repository<User>(dbContext);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
