using Domain.Models.Users;

namespace Domain.Foundation
{
    public interface IUserRepository
    {
        public IRepository<User> Repository { get; }

        public void Commit();
    }
}
