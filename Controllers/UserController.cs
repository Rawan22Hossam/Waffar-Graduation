using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Waffar.DTOs;
using Waffar.Errors;
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

        //[HttpPost("Register")]

        //public async Task<ActionResult<BaseError<string>>> Register(RegisterDto register)
        //{
        //    var result = await _userService.Register(register);
        //    if (result.ErrorCode == (int)ErrorsEnum.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);

        //}
    }
}
