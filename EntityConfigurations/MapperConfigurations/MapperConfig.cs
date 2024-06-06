using AutoMapper;
using AutoMapper;
using Waffar.DTOs;
using Waffar.Models;

namespace Waffar.EntityConfigurations.MapperConfigurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            // User -> AuthenticateResponse
           // CreateMap<User, AuthenticateResponse>();

            // RegisterRequest -> User
            CreateMap<RegisterRequest, User>();
            CreateMap<LoginRequest, User>();    
        }
    }
}
