using Domain.Foundation;
using Domain.Models.Users;

namespace Application.Users
{
    public interface IUserService
    {
        User CreateUser(string login, string password);
        IRepository<User> GetUsers();
        User GetUserInfo(string login, string password);
        void ChangePassword(string login, string password);
        User SetUserInfo(string login, string password, string newUserName, string newDescription);
    }
}
