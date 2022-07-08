using Application.Users;
using WebAPI.Dto;
using WebAPI.Dto.Response;

namespace WebAPI.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserService _userService;


        public UserApiService(IUserService userService)
        {
            _userService = userService;
        }

        public Result CreateUser(UserDto user)
        {
            try
            {
                _userService.CreateUser(user.Login, user.Password);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
            return new Result("", ResponseStatus.Ok);
        }

    }
}
