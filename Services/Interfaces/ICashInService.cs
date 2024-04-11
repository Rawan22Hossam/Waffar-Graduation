using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface ICashInService
    {
        Task<List<CashInTransaction>> GetCashInTransactions();
      //  Task<decimal> GetSavings();
        Task AddCashInTransaction(CashInTransaction transaction);
    }
}
