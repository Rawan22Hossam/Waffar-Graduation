using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Services;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IHistoryService _historyService;
        public HistoryController(IHistoryService historyService) 
        {
            _historyService = historyService;
        }
        [HttpGet("History")]
        public async Task<IActionResult> GetHistory()
        {
            var result = await _historyService.GetBalanceForYear();

            return Ok(result);
        }
    }
}
