using System.ComponentModel.DataAnnotations.Schema;

namespace Waffar.Models
{
    public class Balance
    {
        public int BalanceId { get; set; }
        public int Income { get; set; }
        public int Savings { get; set; }
        public int MoneySpent { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User Users { get; set; }
    }
}
