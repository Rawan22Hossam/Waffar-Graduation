﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Waffar.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillName { get; set; }
        public string BillDescription { get; set; }
        public DateTime BillDueDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User Users { get; set; }
    }
}
