using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IBalanceService
    {
        Task<Balance> GetBalanceForCurrentMonth();
    }
}
