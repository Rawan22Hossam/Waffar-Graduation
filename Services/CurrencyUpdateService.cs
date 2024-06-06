using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class CurrencyUpdateService : ICurrencyUpdateService
    {
        public async Task<decimal> ConvertCurrency(Currency currency)
        {
            // Conversion rates
            Dictionary<string, decimal> conversionRates = new Dictionary<string, decimal>
        {
            // Conversion rates from USD to other currencies
            { "USD_EGP", 15.7m }, // Example rate for USD to EGP
            { "USD_KWD", 0.303m }, // Example rate for USD to KWD
            { "USD_SAR", 3.75m }, // Example rate for USD to SAR
            
            // Conversion rates from other currencies to USD
            { "EGP_USD", 1 / 15.7m }, // Example rate for EGP to USD
            { "KWD_USD", 1 / 0.303m }, // Example rate for KWD to USD
            { "SAR_USD", 1 / 3.75m }, // Example rate for SAR to USD

                {"EGP_SAR", 12.86m },
                {"EGP_KWD", 1/156.59m },
                {"KWD_EGP", 156.59m },
                {"KWD_SAR", 12.16m },
                {"SAR_EGP", 1/12.86m },
                {"SAR_KWD", 1/12.16m }
        };

            // Determine the conversion key based on FromCurrency and ToCurrency
            string conversionKey = $"{currency.FromCurrency.ToUpper()}_{currency.ToCurrency.ToUpper()}";

            decimal convertedAmount;

            // Check if the conversion key exists in the dictionary
            if (conversionRates.ContainsKey(conversionKey))
            {
                // If the conversion key exists, use the corresponding conversion rate
                decimal conversionRate = conversionRates[conversionKey];
                convertedAmount = currency.Amount * conversionRate;
            }
            else
            {
                // If the conversion key doesn't exist, return 0
                convertedAmount = 0;
            }

            // If FromCurrency and ToCurrency are the same, return the original amount
            if (currency.FromCurrency.ToUpper() == currency.ToCurrency.ToUpper())
            {
                convertedAmount = currency.Amount;
            }

            return convertedAmount;
        }
    }
}
