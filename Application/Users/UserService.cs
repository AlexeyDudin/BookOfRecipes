using Domain.Foundation;
using Domain.Models.Users;

namespace Application.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<User> _userRepository;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = unitOfWork.UserRepository;
        }

        public User CreateUser(string login, string password)
        {
            User user = new User
            {
                Login = login,
                Password = password
            };

            _userRepository.Add(user);
            _unitOfWork.Commit();
            return user;
        }
    }
}