using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class DiaryService
    {
        private readonly ApplicationContext _context;

        public DiaryService(ApplicationContext context)
        {
            _context = context;
        }


    }
}
