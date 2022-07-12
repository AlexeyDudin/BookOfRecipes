using Domain.Foundation;
using Domain.Models.Users;

namespace Infrastructure.Foundation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private TLRecipesDbContext _dbContext;
        private IRepository<User> _userRepository;

        public IRepository<User> UserRepository { get { return _userRepository; } }

        public UnitOfWork( TLRecipesDbContext dbContext )
        {
            _userRepository = new Repository<User>( dbContext );
            _dbContext = dbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
