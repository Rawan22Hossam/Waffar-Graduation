using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Models;
using Waffar.Services;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyUpdateController : ControllerBase
    {
        private readonly ICurrencyUpdateService _currencyService;
        public CurrencyUpdateController(ICurrencyUpdateService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpPost("convert")]
        public async Task<IActionResult> ConvertCurrency([FromBody] Currency currency)
        {
            decimal result = await _currencyService.ConvertCurrency(currency);
            return Ok(result);
        }
    }
}
