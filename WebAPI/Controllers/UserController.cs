using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Dto.Response;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    public class UserController : BaseController
    {
        private readonly IUserApiService _userApiService;

        public UserController(IUserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        [HttpPost, Route("")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.CreateUser(user));
        }

        [HttpPost, Route("")]
        public IActionResult GetUserInfo([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.GetUserInfo(user));
        }

        [HttpPost, Route("")]
        public IActionResult SetUserInfo([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.ChangeUserInfo(user));
        }

        [HttpPost, Route("")]
        public IActionResult ChangeUserPassword([FromBody] UserDto user)
        {
            return GetResponse(_userApiService.ChangePassword(user, user.Password));
        }

    }
}
