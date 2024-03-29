﻿using Application.Users.Exceptions;
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

        public void ChangePassword(string login, string password)
        {
            User user = _userRepository.FirstOrDefault(user => user.Login == login);
            user.Password = password;
            _unitOfWork.Commit();
        }

        public User CreateUser(string login, string password, string username, string? description)
        {
            User user = new User
            {
                Login = login,
                Password = password,
                UserName = username,
                Description = description
            };

            if (CheckUserIsNotExist(login))
            {

                _userRepository.Add(user);
                _unitOfWork.Commit();
                return user;
            }
            else
                throw new UserCreationException("Такой пользователь уже существует");
        }

        public User GetUserInfo(string login, string password)
        {
            User user = _userRepository.FirstOrDefault(user => user.Login == login && user.Password == password);
            if (user == null)
                throw new UserAuthException(login, password);
            return user;
        }

        public User GetUser( string login )
        {
            return _userRepository.FirstOrDefault( user => user.Login == login );
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
            _unitOfWork.Commit();
            return changedUser;
        }

        public bool CheckUserIsNotExist(string login)
        {
            User user = _unitOfWork.UserRepository.FirstOrDefault(user => user.Login == login);
            return user == null;
        }
    }
}