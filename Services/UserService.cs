using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
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
        private readonly IGenericRepository<User> _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserService(IConfiguration configuration, IMapper mapper, IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _mapper = mapper;
        }
        public async Task<BaseError<string>> Register(RegisterDto register)
        {
            // map userdto to new entity of user with auto mapper
            var AllUsers = _mapper.Map<User>(register);
            var userdb = _userRepository.GetAll(a => a.Roles).FirstOrDefault(a => a.Name == a.Name);
            if (userdb != null)
                return new BaseError<string>() { ErrorCode = (int)ErrorsEnum.UserAllReadyRegistered, ErrorMessage = ErrorsEnum.UserAllReadyRegistered.ToString() };

            AllUsers.Password = HelperClass.CreatePasswordHash(register.Password);
            var userAdd = _userRepository.Add(AllUsers);
            _userRepository.SaveChanges();
            return new BaseError<string>() { ErrorCode = (int)ErrorsEnum.Success, ErrorMessage = ErrorsEnum.Success.ToString() };

        }

        //public Task<string> LoginAsync(LoginRequest request)
        //{
        //    // Validate credentials and generate JWT token
        //}
    }
}
