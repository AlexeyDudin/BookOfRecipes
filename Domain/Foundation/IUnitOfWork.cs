using Domain.Models.Users;

namespace Domain.Foundation
{
    public interface IUnitOfWork
    {
        public IRepository<User> UserRepository { get; }

        public void Commit();
    }
}
