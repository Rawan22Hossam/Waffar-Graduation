using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IDiaryService
    {
        Task<IEnumerable<Diary>> GetEntriesAsync();
        Task<Diary> GetEntryByIdAsync(int id);
        Task<Diary> AddEntryAsync(Diary model);
    }
}
