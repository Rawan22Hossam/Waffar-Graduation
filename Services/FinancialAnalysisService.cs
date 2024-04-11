using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class FinancialAnalysisService : IFinancialAnalysisService
    {
        private readonly ApplicationContext _context;
        public FinancialAnalysisService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Balance> GetBalanceChart()
        {
            DateTime currentDate = DateTime.Today;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            // Filter cash in transactions for the current month
            decimal totalIncome = _context.CashIns
                .Where(t => t.Date.Month == currentMonth && t.Date.Year == currentYear)
                .Sum(t => t.Amount);

            // Filter cash out transactions for the current month
            decimal totalExpenses = _context.CashOuts
                .Where(t => t.Date.Month == currentMonth && t.Date.Year == currentYear)
                .Sum(t => t.Amount);

            // Calculate total savings for the current month
            decimal totalSavings = totalIncome - totalExpenses;

            return new Balance
            {
                Income = totalIncome,
                MoneySpent = totalExpenses
            };
        }
    }
}
