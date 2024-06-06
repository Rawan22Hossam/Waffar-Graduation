using Waffar.DTOs;
using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IUserService
    {
        User Register(User newUser);
        //Task LoginAsync(string name, string password);
    }
}
