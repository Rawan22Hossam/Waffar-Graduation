using System.ComponentModel.DataAnnotations.Schema;

namespace Waffar.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User Users { get; set; }
    }
}
