using Microsoft.AspNetCore.Mvc;

namespace sussed_online.backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SussedController : ControllerBase
    {
        public SussedController()
        {
        }

        [HttpPost]
        [Route("/users")]
        public void CreateUser(string name)
        {
        }

        [HttpGet]
        public void SelectedUserGetQuestion(int userId)
        {
            
        }

        [HttpPost]
        public void SelectedUserAnswer(int userId, int questionId, int answerId)
        {
            // Store the answer
        }

        [HttpPost]
        public int OtherUserAnswer(int userId, int questionId, int answerId)
        {
            // Calculate the points for the user
            return 0;
        }
    }
}