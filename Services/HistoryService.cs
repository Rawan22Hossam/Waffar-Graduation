using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly ApplicationContext _context;
        public HistoryService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Balance>> GetBalanceForYear()
        {
            // Get the current year
            int currentYear = DateTime.Today.Year;

            // Initialize a list to store balances for each month
            List<Balance> balances = new List<Balance>();

            // Loop through each month of the year
            for (int month = 1; month <= 12; month++)
            {
                // Filter cash in transactions for the current month
                decimal totalIncome = _context.CashIns
                    .Where(t => t.Date.Month == month && t.Date.Year == currentYear)
                    .Sum(t => t.Amount);

                // Filter cash out transactions for the current month
                decimal totalExpenses = _context.CashOuts
                    .Where(t => t.Date.Month == month && t.Date.Year == currentYear)
                    .Sum(t => t.Amount);

                // Calculate total savings for the current month
                decimal totalSavings = totalIncome - totalExpenses;

                // Create a balance object for the current month
                var balance = new Balance
                {
                    Month = month,
                    Year = currentYear,
                    Savings = totalSavings,
                    MoneySpent = totalExpenses,
                    Income = totalIncome
                };

                // Add the balance object to the list
                balances.Add(balance);
            }

            return balances;
        }
    }
}
   
