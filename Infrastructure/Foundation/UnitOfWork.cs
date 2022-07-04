using Domain.Foundation;
using Domain.Repositories;
using Infrastructure.Repositories;

namespace Infrastructure.Foundation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private TLRecipesDbContext _dbContext;
        private IUserRepository _userRepository;

        public IUserRepository UserRepository { get { return _userRepository; } }

        public UnitOfWork( TLRecipesDbContext dbContext )
        {
            _userRepository = new UserRepository( dbContext );
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
