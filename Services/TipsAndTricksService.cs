using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using Waffar.Models;
using Waffar.Services.Interfaces;
namespace Waffar.Services
{
    public class TipsAndTricksService : ITipsAndTricksService
    {
        private readonly ApplicationContext  _context;
        public TipsAndTricksService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<TipsAndTricks> GetRandomTip()
        {
            var tips = await _context.TipsAndTricks.ToListAsync();

            if (tips.Any())
            {
                Random random = new Random();
                int randomIndex = random.Next(0, tips.Count);
                return tips[randomIndex];
            }
            else
            {
                return null;
            }
        }
        public async Task AddTipAsync(string tip)
        {
            var newTip = new TipsAndTricks 
            { TipsAndTricksText = tip };
            _context.TipsAndTricks.Add(newTip);
            await _context.SaveChangesAsync();
        }
    }
}
