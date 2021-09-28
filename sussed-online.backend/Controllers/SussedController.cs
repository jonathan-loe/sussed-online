using Microsoft.AspNetCore.Mvc;
using sussed_online.backend.Models;
using sussed_online.backend.Services;

namespace sussed_online.backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SussedController : ControllerBase
    {
        private readonly ISussedService _sussedService;
        public SussedController(ISussedService sussedService)
        {
            _sussedService = sussedService;
        }

        [HttpPost("users")]
        public IActionResult CreateUser([FromBody]CreateUserRequest request)
        {
            int id = _sussedService.CreateUser(request.Name);
            return new OkObjectResult(id);
        }

        [HttpGet]
        public IActionResult SelectedUserGetQuestion(int userId)
        {
            var question = _sussedService.GetQuestion(userId);

            return new OkObjectResult(question);
        }

        [HttpPost]
        public IActionResult SelectedUserAnswer([FromBody]UserAnswerRequest request)
        {
           _sussedService.SaveAnswer(request);
           return Ok();
        }
        [HttpGet]
        public IActionResult OtherUserGetQuestion(int userId)
        {
            var question = _sussedService.GetOtherUserQuestion(userId);

            return new OkObjectResult(question);
        }
        [HttpPost]
        public int OtherUserAnswer(int userId, int questionId, int answerId)
        {
            // Calculate the points for the user
            return 0;
        }
    }
}