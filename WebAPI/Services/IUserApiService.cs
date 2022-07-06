using WebAPI.Dto;

namespace WebAPI.Services
{
    public interface IUserApiService
    {
        void CreateUser(UserDto user);
    }
}
