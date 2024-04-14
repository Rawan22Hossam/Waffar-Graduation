using Waffar.DTOs;

namespace Waffar.Services.Interfaces
{
    public interface IUserService
    {
        Task<BaseError<string>> Register(RegisterDto register);
    }
}
