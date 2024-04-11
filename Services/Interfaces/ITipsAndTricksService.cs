using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface ITipsAndTricksService
    {
        Task<TipsAndTricks> GetRandomTip();
        Task AddTipAsync(string tip);
    }
}
