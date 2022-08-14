using WebAPI.Dto;
using WebAPI.Dto.Response;

namespace WebAPI.Services.User
{
    public interface IUserApiService
    {
        Result CreateUser(UserDto user);
        Result GetUserInfo(UserDto user);
        Result ChangeUserInfo(UserDto user);
        Result ChangePassword(UserDto user, string password);
        Result GetAllUsers();
    }
}
