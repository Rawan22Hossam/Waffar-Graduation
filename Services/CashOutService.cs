using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Services
{
    public class CashOutService : ICashOutService
    {
        private readonly ApplicationContext _context;

        public CashOutService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<CashOutTransaction>> GetCashOutTransactions()
        {
            return  _context.CashOuts.OrderByDescending(t => t.Date).ToList();
        }

        public async Task<decimal> GetSavings()
        {
            var cashIns = _context.CashIns.Sum(t => t.Amount);
            var cashOuts = _context.CashOuts.Sum(t => t.Amount);
            var savings = cashIns - cashOuts;
            return savings;
        }

        public async Task AddCashOutTransaction(CashOutTransaction transaction)
        {
            _context.CashOuts.Add(transaction);
            await _context.SaveChangesAsync();
        }
    }
}
