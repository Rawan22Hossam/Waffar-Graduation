using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Waffar.DTOs;
using Waffar.Errors;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Services
{
    public class RoleService : IRoleService
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public RoleService(IConfiguration configuration, IMapper mapper)
        {
            _mapper = mapper;
            _configuration = configuration;
        }
        /*   public async Task<List<string>> GetRolesAsync()
           {
               var roleList = 
           }
           public async Task<List<string>> GetUserRolesAsync(string UserEmail)
           {
               var user = await _userManager.FindByEmailAsync(UserEmail);
               var userRoles = await _userManager.GetRolesAsync(user);
               return userRoles.ToList();
           }
           public async Task<object> AddRolesAsync(string[] roles)
           {
               var rolesList = new List<string>();
               foreach (var role in roles) 
               {
                  if(!await _roleManager.RoleExistsAsync(role))
                   {
                       await _roleManager.CreateAsync(new IdentityRole (role));
                       rolesList.Add(role);
                   }
                    return new BaseError<string>()
                   {
                       ErrorCode = (int)ErrorsEnum.UserRoleAlreadyExist,
                       ErrorMessage = ErrorsEnum.UserRoleAlreadyExist.ToString()
                   };

               }
               return rolesList;
           }

           public async Task<BaseError<string>> AddUserRoleAsync(string userEmail, string[] roles)
           {
               var user = await _userManager.FindByEmailAsync(userEmail);

               var exitsRoles = await ExistsRolesAsync(roles);

               if (user != null && exitsRoles.Count == roles.Length)
               {
                   var assginRoles = await _userManager.AddToRolesAsync(user, exitsRoles);
                   return new BaseError<string>()
                   {
                       ErrorCode = (int)ErrorsEnum.Success,
                       ErrorMessage = ErrorsEnum.Success.ToString()
                   };
               }

               return new BaseError<string>()
               {
                   ErrorCode = (int)ErrorsEnum.UserRoleDoesnotExist,
                   ErrorMessage = ErrorsEnum.UserRoleDoesnotExist.ToString()
               };

           }

           private async Task<List<string>> ExistsRolesAsync(string[] roles)
           {
               var rolesList = new List<string>();
               foreach (var role in roles)
               {
                   var roleExist = await _roleManager.RoleExistsAsync(role);
                   if (roleExist)
                   {
                       rolesList.Add(role);
                   }
               }
               return rolesList;

           }
       }
        */
    }
}
