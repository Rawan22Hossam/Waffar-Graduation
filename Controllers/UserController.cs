using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Waffar.DTOs;
using Waffar.Errors;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (newUser == null)
            {
                return BadRequest("User data is null.");
            }

            // You can add validation logic here

            var registeredUser = _userService.Register(newUser);
            return Ok(registeredUser);
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login(string name , string password)
        //{
        //    var user = await _userService.LoginAsync(name, password);
        //    if (user != null)
        //    {
        //        return Ok(new { message = "Login successful" });
        //    }
        //    else
        //    {
        //        return Unauthorized(new { message = "Invalid username or password" });
        //    }
        //}
    }
}
