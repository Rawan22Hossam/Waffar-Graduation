using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using System.Security.Cryptography;
using System.Text;
using Waffar.Context;
using Waffar.DTOs;
using Waffar.Errors;
using Waffar.GenericRepository;
using Waffar.Helper;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _context;
        private readonly IGenericRepository<User> _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserService(ApplicationContext context,IConfiguration configuration, IMapper mapper, IGenericRepository<User> userRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _configuration = configuration;
            _mapper = mapper;
        }

        public User Register(User newUser)
        {
            // Hash the password
            newUser.Password = CreatePasswordHash(newUser.Password);

            _context.Add(newUser);
            _context.SaveChanges();

            return newUser;
        }

        public static string CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {

                return hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)).ToString();
            }
        }

        //public Task<LoginRequest> LoginAsync(string name, string password)
        //{
        //    return _context.Users
        //        .FirstOrDefaultAsync(u => u.Name == name && u.Password == password);
            
        //}
    }
}
