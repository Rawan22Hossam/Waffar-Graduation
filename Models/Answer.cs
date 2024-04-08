namespace Waffar.Models
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
        public int QuestionId { get; set; }
        public Question Questions { get; set; }
    }
}
