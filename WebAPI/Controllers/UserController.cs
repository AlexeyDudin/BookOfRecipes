using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IUserApiService _userApiService;

        public UserController(IUserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        [HttpPost, Route("")]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            _userApiService.CreateUser(user);
            return Ok();
        }
    }
}
