using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IHistoryService
    {
        Task<List<Balance>> GetBalanceForYear();
    }
}
