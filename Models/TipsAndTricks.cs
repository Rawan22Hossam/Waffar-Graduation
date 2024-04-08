namespace Waffar.Models
{
    public class TipsAndTricks
    {
        public int TipsId { get; set; }
        public string TipsAndTricksText { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }    
    }
}
