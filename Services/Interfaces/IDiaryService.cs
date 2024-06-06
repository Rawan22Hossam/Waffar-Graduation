using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IDiaryService
    {
        List<Diary> GetAllEntries();
        Task<Diary> GetEntryById(int id);
        Diary AddEntry(Diary entry);
    }
}
