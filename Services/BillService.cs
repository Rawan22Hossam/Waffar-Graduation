using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class BillService : IBillService
    {
        private readonly ApplicationContext _context;
        public BillService(ApplicationContext context)
        {
            _context = context;
        }
        public List<Bill> GetBillsDueToday()
        {
            DateTime today = DateTime.Today;
            return _context.Bills.Where(b => b.BillDueDate.Date == today).ToList();
        }

        public async Task<string> AddBill(string billName, DateTime billDueDate, string billDescription)
        {
            var bill = new Bill
            {
                BillName = billName,
                BillDueDate = billDueDate,
                BillDescription = billDescription
            };

            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
            return "Bill added successfully";
        }

    }
}
