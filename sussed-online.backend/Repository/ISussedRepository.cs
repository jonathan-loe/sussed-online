using sussed_online.backend.Models;

namespace sussed_online.backend.Repository
{
    public interface ISussedRepository
    { 
        int CreateUser(string name);
        Question GetQuestion(int userId);
        void SaveAnswer(UserAnswerRequest request);
        Question GetOtherUserQuestion(int userId);
        
    }
}