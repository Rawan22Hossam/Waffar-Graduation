using AutoMapper;
using Waffar.DTOs;
using Waffar.Models;

namespace Waffar.EntityConfigurations.MapperConfigurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
             CreateMap<User, UserRole>();
        }
    }
}
