using sussed_online.backend.Models;

namespace sussed_online.backend.Services
{
    public interface ISussedService
    {
        int CreateUser(string name);
        Question GetQuestion(int userId);
        void SaveAnswer(UserAnswerRequest request);
        Question GetOtherUserQuestion(int userId);
    }
}