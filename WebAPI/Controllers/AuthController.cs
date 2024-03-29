﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;
using WebAPI.Services.User;

namespace WebAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IUserApiService _userApiService;

        public AuthController(IUserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Authenticate([FromBody] UserDto userLoginDto)
        {
            return GetResponse(_userApiService.Login(userLoginDto));
        }
    }
}
