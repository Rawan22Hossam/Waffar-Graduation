using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Waffar.Models;
using Waffar.Services;
using Waffar.Services.Interfaces;

namespace Waffar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotController : ControllerBase
    {
        private readonly IChatbotService _chatbotService;
        public ChatbotController(IChatbotService chatbotService) 
        {
            _chatbotService = chatbotService;
        }
      /*  [HttpPost("Chatbot")]
        public async Task<IActionResult> AskQuestionAsync([FromForm] Question model)
        {
            var result = await _chatbotService.AskQuestionAsync(model);
            return Ok(result);
        }
      */

        [HttpGet("ShowQuestions")]
        public async Task<ActionResult> GetallQuestionAsync()
        {
            var result =await _chatbotService.GetAllQuestions();
            return Ok(result);
        }
        [HttpGet("AnswerQuestion")]
        public async Task<IActionResult> AskQuestion(int questionId)
        {
            var result = await _chatbotService.GetAnswerForQuestionAsync(questionId);
            return Ok(result);
        }
        [HttpPost("AddQuestions")]
        public async Task<IActionResult> AddQuestion(Question questionText)
        {
            var result = await _chatbotService.AddQuestionAsync(questionText.QuestionText);
            return Ok(result);
        }
        [HttpPost("AddAnswer")]
        public async Task<IActionResult> AddAnser(string answerText , int questionId)
        {
            var result = await _chatbotService.AddAnswerAsync(answerText, questionId);
            return Ok(result);
        }



    }
}
