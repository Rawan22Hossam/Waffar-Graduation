using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IBillService
    {
        List<Bill> GetBillsDueToday();
        Task<string> AddBill(string billName, DateTime billDueDate, string billDescription);
    }
}
