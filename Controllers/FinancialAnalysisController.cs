using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialAnalysisController : ControllerBase
    {
        private readonly IFinancialAnalysisService _analysisService;
        public FinancialAnalysisController(IFinancialAnalysisService analysisService)
        {
            _analysisService = analysisService;
        }
        [HttpGet("financial-analysis-charts")]
        public async Task<IActionResult> GetPieChart()
        {
            var chart = await _analysisService.GetBalanceChart();
            return Ok(chart);
        }
    }
}
