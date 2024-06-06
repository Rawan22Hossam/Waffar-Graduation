using Microsoft.EntityFrameworkCore.Infrastructure;
using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class DiaryService : IDiaryService
    {
        private readonly ApplicationContext _context;

        public DiaryService(ApplicationContext context)
        {
            _context = context;
        }
        public List<Diary> GetAllEntries()
        {
            return  _context.Diary.ToList();
        }

        public async Task<Diary> GetEntryById(int id)
        {
            return  _context.Diary.FirstOrDefault(e => e.DiaryId == id);
        }

        public Diary AddEntry(Diary entry)
        {
            entry.CreatedAt = DateTime.UtcNow;
            _context.Add(entry);
            _context.SaveChanges();
            return entry;
        }


    }
}
