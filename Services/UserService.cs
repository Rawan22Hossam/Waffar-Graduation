using Microsoft.AspNetCore.Identity.Data;
using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;
        public UserService()
        {

        }
        //public Task<User> RegisterAsync(RegisterRequest request)
        //{
        //    // Validate and create user account
        //}

        //public Task<string> LoginAsync(LoginRequest request)
        //{
        //    // Validate credentials and generate JWT token
        //}
    }
}
