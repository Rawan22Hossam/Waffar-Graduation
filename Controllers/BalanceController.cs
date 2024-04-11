using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceService _balanceService;
        public BalanceController(IBalanceService balanceService)
        {
            _balanceService = balanceService;
        }
        [HttpGet("current-month-balance")]
        public async Task<IActionResult> GetCurrentMonthBalance()
        {
            var balance = await _balanceService.GetBalanceForCurrentMonth();
            return Ok(balance);
        }
    }
}
