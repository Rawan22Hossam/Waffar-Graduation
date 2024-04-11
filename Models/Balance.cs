using Microsoft.AspNetCore.Mvc;

namespace Waffar.Models
{
    public class Balance
    {
        internal string PieChartData;
        public int Month { get; set; }
        public int Year { get; set; }
        public int BalanceId { get; set; }
        public decimal Income { get; set;}
        public decimal Savings { get; set;}
        public decimal MoneySpent { get; set;}

    }
}
