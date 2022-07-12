using Domain.Models.Users;
using WebAPI.Dto;

namespace WebAPI.Converters
{
    public static class UserConverter
    {
        public static User ConverUserFromDto(UserDto user)
        {
            return new User
            {
                Login = user.Login,
                Password = user.Password,
                Description = user.Description,
                UserName = user.UserName
            };
        }

        public static UserDto ConvertUserToDto(User user)
        {
            return new UserDto
            {
                Login = user.Login,
                Password = user.Password,
                Description = user.Description,
                UserName = user.UserName
            };
        }
    }
}
