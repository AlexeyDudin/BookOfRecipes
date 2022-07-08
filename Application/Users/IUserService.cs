using Domain.Models.Users;

namespace Application.Users
{
    public interface IUserService
    {
        User CreateUser(string login, string password);
        List<User> GetUsers();
        User GetUser(string login, string password);
    }
}
