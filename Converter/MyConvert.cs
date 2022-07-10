using Domain.Models.Users;
using WebAPI.Dto;

namespace Converter
{
    public class MyConvert : Convert
    {
        public static User UserDtoToUser(UserDto userDto)
        {
            User user = new User();
            user.Login = userDto.Login;
            user.Password = userDto.Password;
            user.UserName = userDto.UserName;
            user.Description = userDto.Description;
            return user;
        }

        public static UserDto UserToUserDto(User user)
        {
            UserDto userDto = new UserDto();
            userDto.Login = user.Login;
            userDto.Password = user.Password;
            userDto.Description = user.Description;
            userDto.UserName = user.UserName;
            return userDto;
        }
    }
}