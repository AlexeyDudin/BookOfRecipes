using Application.Users;
using System.Text.Json;
using WebAPI.Converters;
using WebAPI.Dto;
using WebAPI.Dto.Response;
using WebAPI.Security.Auths;

namespace WebAPI.Services.User
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public UserApiService(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        public Result CreateUser(UserDto user)
        {
            try
            {
                return new Result(JsonSerializer.Serialize(UserConverter.ConvertUserToDto(_userService.CreateUser(user.Login, user.Password, user.UserName, user.Description))), ResponseStatus.Ok);
            }
            catch (ArgumentException ex)
            {
                return new Result(ex.Message, ResponseStatus.UserIsNotUnique);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result GetUserInfo(UserDto user)
        {
            try
            {
                return new Result(JsonSerializer.Serialize(_userService.GetUserInfo(user.Login, user.Password)), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result ChangePassword(UserDto user, string password)
        {
            try
            {
                _userService.ChangePassword(user.Login, password);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }

            return new Result("User password changed", ResponseStatus.Ok);
        }

        public Result ChangeUserInfo(UserDto newUserInfo)
        {
            try
            {
                _userService.SetUserInfo(newUserInfo.Login, newUserInfo.Password, newUserInfo.UserName, newUserInfo.Description);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
            return new Result("User info saved", ResponseStatus.Ok);
        }

        public Result GetAllUsers()
        {
            try
            {
                return new Result(JsonSerializer.Serialize(_userService.GetUsers()), ResponseStatus.Ok);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
        }

        public Result Login( UserLoginDto userLoginDto )
        {
            try
            {
                string token = _tokenService.GenerateToken( userLoginDto );
                ResponseStatus responseStatus = string.IsNullOrEmpty( token ) ? ResponseStatus.UserNotFound : ResponseStatus.Ok;
                return new Result(token, responseStatus);  
            }
            catch ( Exception ex )
            {
                return new Result( ex.Message, ResponseStatus.Error );
            }
        }
    }
}
