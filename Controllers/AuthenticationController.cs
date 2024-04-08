using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.DTOs;
using Waffar.Models;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMapper _mapper;
        public AuthenticationController(IMapper mapper)
        {
            _mapper = mapper;
        }

    /*    [HttpGet]
        public async Task<string> RegisterationAsync(RegisterDto register) 
        {
           var registerationData = _mapper.Map<User>(register);

            if (registerationData == null) 
            { return "Please enter your Credentials"; }

            if (registerationData.Password.Length < 9)
            { return "Weak Password , Please enter more tan 9 characters"; }
           

        }
    */
    }
}
