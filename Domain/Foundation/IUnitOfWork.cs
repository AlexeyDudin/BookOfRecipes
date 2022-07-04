using Domain.Repositories;

namespace Domain.Foundation
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        void Commit();
    }
}
