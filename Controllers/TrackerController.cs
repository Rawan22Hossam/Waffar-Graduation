using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackerController : ControllerBase
    {
        private readonly ICashInService _cashInService;
        private readonly ICashOutService _cashOutService;

        public TrackerController(ICashInService cashInService, ICashOutService cashOutService)
        {
            _cashInService = cashInService;
            _cashOutService = cashOutService;
        }

        // API endpoint to get all cash in transactions
        [HttpGet("get all cash-in")]
        public async Task<IActionResult> GetCashInTransactions()
        {
            var transactions = await _cashInService.GetCashInTransactions();
            return Ok(transactions);
        }

        // API endpoint to add a new cash in transaction
        [HttpPost("add cash-in")]
        public async Task<IActionResult> AddCashInTransaction([FromBody] CashInTransaction transaction)
        {
           await _cashInService.AddCashInTransaction(transaction);
            return Ok("Cash in transaction added successfully.");
        }

        // API endpoint to get all cash out transactions
        [HttpGet("get all cash-out")]
        public async Task<IActionResult> GetCashOutTransactions()
        {
            var transactions = await _cashOutService.GetCashOutTransactions();
            return Ok(transactions);
        }

        // API endpoint to add a new cash out transaction
        [HttpPost("add cash-out")]
        public async Task<IActionResult> AddCashOutTransaction([FromBody] CashOutTransaction transaction)
        {
            await _cashOutService.AddCashOutTransaction(transaction);
            return Ok("Cash out transaction added successfully.");
        }

        // API endpoint to get the current savings
        [HttpGet("savings")]
        public async Task<IActionResult> GetSavings()
        {
            var savings = await _cashOutService.GetSavings();
            return Ok($"Current savings: {savings}");
        }
    }
}
