using WebAPI.Dto;
using WebAPI.Dto.Response;

namespace WebAPI.Services
{
    public interface IUserApiService
    {
        Result CreateUser(UserDto user);
    }
}
