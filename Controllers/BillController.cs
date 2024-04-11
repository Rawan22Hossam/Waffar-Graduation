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
        [HttpGet("Reminders")]
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

        [HttpPost("AddBill")]
        public async Task<IActionResult> PostBillReminders(string billName, DateTime billDueDate, string billDescription)
        {
            if (string.IsNullOrWhiteSpace(billName) || billDueDate == default || string.IsNullOrWhiteSpace(billDescription))
            {
                return BadRequest("Bill name and due date are required.");
            }
            var result = await _billService.AddBill(billName, billDueDate, billDescription);
            return Ok(result);
        }

    }
}
