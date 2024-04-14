using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsAndTricksController : ControllerBase
    {
        private readonly ITipsAndTricksService _tipsService;

        public TipsAndTricksController(ITipsAndTricksService tipsService)
        {
            _tipsService = tipsService;
        }

        [HttpGet("show-random-tip")]
        public async Task<IActionResult> GetRandomTip()
        {
            var tip = await _tipsService.GetRandomTip();

            if (tip != null)
            {
                return Ok(tip);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("add-new-tip")]
        public async Task<IActionResult> AddTip([FromBody] string tip)
        {
            await _tipsService.AddTipAsync(tip);
            return Ok("Tip added successfully.");
        }
    }
}
