using Waffar.Models;

namespace Waffar.Services.Interfaces
{
    public interface IChatbotService
    {
       // Task<object> AskQuestionAsync(Question model);
        Task<object> GetAnswerForQuestionAsync(int questionId);
        Task<List<Question>> GetAllQuestions();
        Task<string> AddQuestionAsync(string questionText);
        Task<object> AddAnswerAsync(string answerText, int questionId);
    }
}
