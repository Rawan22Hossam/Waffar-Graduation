using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface ICurrencyUpdateService
    {
        Task<decimal> ConvertCurrency(Currency currency);
    }
}
