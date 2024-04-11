using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IBillService
    {
        public List<Bill> GetBillsDueToday();
    }
}
