using Application.Users;
using WebAPI.Dto;

namespace WebAPI.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserService _userService;


        public UserApiService(IUserService userService)
        {
            _userService = userService;
        }

        public void CreateUser(UserDto user)
        {
            _userService.CreateUser(user.Login, user.Password);
        }

    }
}
