using Domain.Foundation;
using Domain.Models.Users;

namespace Application.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _unitOfWork;
        private readonly IRepository<User> _userRepository;

        public UserService(IUserRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = unitOfWork.Repository;
        }

        public void ChangePassword(string login, string password)
        {
            User user = _userRepository.FirstOrDefault(user => user.Login == login);
            user.Password = password;
            //User changedUser = UserFunctions.Clone(user);
            //changedUser.Password = password;
            //_userRepository.Change(user, changedUser);
            //TODO
            _unitOfWork.Commit();
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

        public User GetUserInfo(string login, string password)
        {
            return _userRepository.FirstOrDefault(user => user.Login == login && user.Password == password);
        }

        public List<User> GetUsers()
        {
            List<User> userList = _userRepository.GetAll();
            return userList;
        }

        public User SetUserInfo(string login, string password, string newUserName, string newDescription)
        {
            User changedUser = _userRepository.FirstOrDefault(changedUser => changedUser.Login == login && changedUser.Password == password);
            changedUser.UserName = newUserName;
            changedUser.Description = newDescription;
            //User newUserInfo = UserFunctions.Clone(changedUser);
            //newUserInfo.Description = newDescription;
            //newUserInfo.UserName = newUserName;
            //_userRepository.Change(changedUser, newUserInfo);
            _unitOfWork.Commit();
            return changedUser;
        }
    }
}