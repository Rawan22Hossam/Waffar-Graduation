using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Services
{
    public class CashInService : ICashInService
    {
        private readonly ApplicationContext _context;

        public CashInService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<CashInTransaction>> GetCashInTransactions()
        {
            return _context.CashIns.OrderByDescending(t => t.Date).ToList();
        }

        //public async Task<decimal> GetSavings()
        //{
        //    return _context.CashIns.Sum(t => t.Amount);
        //}

        public async Task AddCashInTransaction(CashInTransaction transaction)
        {
            _context.CashIns.Add(transaction);
            await _context.SaveChangesAsync();

        }
    }
}

