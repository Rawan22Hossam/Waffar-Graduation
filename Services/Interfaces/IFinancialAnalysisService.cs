using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IFinancialAnalysisService
    {
        Task<Balance> GetBalanceChart();
    }
}
