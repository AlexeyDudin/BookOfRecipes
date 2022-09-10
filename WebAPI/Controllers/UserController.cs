using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Dto.Response;
using WebAPI.Services.User;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    public class UserController : BaseController
    {
        private readonly IUserApiService _userApiService;

        public UserController( IUserApiService userApiService )
        {
            _userApiService = userApiService;
        }

        [HttpPost, Route("")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.CreateUser(new UserDto() { Login = user.Login, Password = user.Password })) ;
        }

        [HttpGet, Route("")]
        public IActionResult GetUserInfo([FromQuery] UserDto user)
        {
            return GetResponse(_userApiService.GetUserInfo(user));
        }

        [Authorize]
        [HttpGet, Route("all")]
        public IActionResult GetAllUser()
        {
            return GetResponse(_userApiService.GetAllUsers());
        }

        [HttpPost, Route("update")]
        public IActionResult UpdateUser([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.ChangeUserInfo(user));
        }

        [HttpPost, Route("password")]
        public IActionResult ChangeUserPassword([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.ChangePassword(user, user.Password));
        }
    }
}
