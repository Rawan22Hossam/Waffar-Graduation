using ChatGPT.Net;
using Waffar.DTOs;
using Waffar.Errors;
using Waffar.Models;
using Waffar.Services.Interfaces;
using ChatGPT;
using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using System.ComponentModel;
namespace Waffar.Services
{
    public class ChatbotService : IChatbotService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationContext _context;
        public ChatbotService(IConfiguration configuration, ApplicationContext context)
        {
            _configuration = configuration;
            _context = context;

        }
        #region Ai Chatbot
        public async Task<object> AskQuestionAsync(Question model)
        {
            var apiKey = _configuration["ApiKeys:Gemini"];
            try
            {
                if (apiKey == null)
                {
                    return new BaseError<string>()
                    {
                        ErrorCode = (int)ErrorsEnum.ApiKeyFoeChatGptIsMissing,
                        ErrorMessage = ErrorsEnum.ApiKeyFoeChatGptIsMissing.ToString()
                    };
                }
                var openAi = new ChatGpt(apiKey);
                var answer = await openAi.Ask(model.QuestionText);

                if (answer == null || string.IsNullOrEmpty(answer))
                    return new BaseError<string>()
                    {
                        ErrorCode = (int)ErrorsEnum.AnswerIsNull,
                        ErrorMessage = ErrorsEnum.AnswerIsNull.ToString()
                    };
                return new Answer() { AnswerDescription = answer };
            }
            catch
            {
                return new BaseError<string>()
                {
                    ErrorCode = (int)ErrorsEnum.ChatGptServiceIsUnavailable,
                    ErrorMessage = ErrorsEnum.ChatGptServiceIsUnavailable.ToString()
                };

            }
        }
        #endregion

        #region Manual Chatbot

        public async Task<List<Question>> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }
        public async Task<object> GetAnswerForQuestionAsync(int questionId)
            {
                // Search for the question in the database by ID
                var question = await _context.Questions.FindAsync(questionId);

                if (question != null)
                {
                    // If the question is found, get the corresponding answer
                    var answer = await _context.Answers.FirstOrDefaultAsync(a => a.QuestionId == question.QuestionId);

                    if (answer != null)
                    {
                        // Return the answer text
                        return answer.AnswerDescription;
                    }
                }

            // If no matching question or answer found, return null or handle accordingly
            return new BaseError<string>()
            {
                ErrorCode = (int)ErrorsEnum.NoMatchingQuestion,
                ErrorMessage = ErrorsEnum.NoMatchingQuestion.ToString()
            };
        }
        #endregion

        #region Admin Chatbot

        public async Task<string> AddQuestionAsync(string questionText)
        {
            var question = new Question
            {
                QuestionText = questionText
            };

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
            return "Question added Successfully";
        }

        public async Task<object> AddAnswerAsync(string answerText , int questionId)
        {
            var answer = new Answer
            {
                AnswerDescription = answerText,
                QuestionId = questionId
            };
            _context.Answers.Add(answer);
            await _context.SaveChangesAsync();
            return "Answer added successfully";
        }


        #endregion
    }
}
