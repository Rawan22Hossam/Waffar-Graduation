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

    
    }
}
