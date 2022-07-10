﻿using Application.Users;
using System.Text.Json;
using WebAPI.Dto;
using WebAPI.Dto.Response;

namespace WebAPI.Services
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserService _userService;


        public UserApiService(IUserService userService)
        {
            _userService = userService;
        }

        public Result CreateUser(UserDto user)
        {
            try
            {
                _userService.CreateUser(user.Login, user.Password);
            }
            catch (Exception ex)
            {
                return new Result(ex.Message, ResponseStatus.Error);
            }
            return new Result("User added", ResponseStatus.Ok);
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

    }
}
