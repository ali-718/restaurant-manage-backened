using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Manage_Backened.Dtos.AuthDtos;
using Restaurant_Manage_Backened.Helpers.Response;
using Restaurant_Manage_Backened.Models;

namespace Restaurant_Manage_Backened.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authService;
        private readonly ActionResponse _responseHelper;
        public AuthController(IAuthRepository authService, ActionResponse responseHelper)
        {
            _authService = authService;
            _responseHelper = responseHelper;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(RegisterUserDto user)
        {
            var newUser = new User
            {
                Username = user.Username,
            };
            var response = await _authService.Register(newUser, user.Password);
            return _responseHelper.GetActionResult(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(LoginUserDto user)
        {
            var response = await _authService.Login(user.Username, user.Password);
            return _responseHelper.GetActionResult(response);
        }
    }
}