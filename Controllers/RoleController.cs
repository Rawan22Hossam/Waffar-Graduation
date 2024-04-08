using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.DTOs;
using Waffar.Services;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        public RoleController(IRoleService roleService , IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }
     //   [Authorize(Roles = "Admin")]
     //   [HttpGet("Get User Role")]
       
    }
}
