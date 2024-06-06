using Microsoft.AspNetCore.Mvc;
using Waffar.Models;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryController : ControllerBase
    {
        private readonly IDiaryService _diaryService;

        public DiaryController(IDiaryService diaryService)
        {
            _diaryService = diaryService;
        }

        [HttpGet]
        public IActionResult GetAllEntries()
        {
            var entries = _diaryService.GetAllEntries();
            return Ok(entries);
        }

        [HttpGet("{id}")]
        public IActionResult GetEntryById(int id)
        {
            var entry = _diaryService.GetEntryById(id);
            if (entry == null)
            {
                return NotFound();
            }
            return Ok(entry);
        }

        [HttpPost]
        public IActionResult AddEntry(Diary entry)
        {
            var addedEntry = _diaryService.AddEntry(entry);
            return CreatedAtAction(nameof(GetEntryById), new { id = addedEntry.DiaryId }, addedEntry);
        }
    }
}
