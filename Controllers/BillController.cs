using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;
        public BillController(IBillService billService)
        { 
            _billService = billService;
        }
        [HttpGet("reminders")]
        public IActionResult GetBillReminders()
        {
            var billsDueToday = _billService.GetBillsDueToday();

            if (billsDueToday.Any())
            {
                var message = "Bills due today:\n";
                foreach (var bill in billsDueToday)
                {
                    message += $"{bill.BillName}: {bill.BillDescription}\n";
                }
                return Ok(message);
            }
            else
            {
                return Ok("No bills due today.");
            }
        }
    }
}
