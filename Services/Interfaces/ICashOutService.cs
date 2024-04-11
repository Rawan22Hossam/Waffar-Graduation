using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface ICashOutService
    {
        Task<List<CashOutTransaction>> GetCashOutTransactions();
       Task<decimal> GetSavings();
        Task AddCashOutTransaction(CashOutTransaction transaction);
    }
}
