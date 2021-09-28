using sussed_online.backend.Models;
using sussed_online.backend.Repository;

namespace sussed_online.backend.Services
{
    public class SussedService : ISussedService
    {
        private readonly ISussedRepository _sussedRepository;
        public SussedService(ISussedRepository sussedRepository)
        {
            _sussedRepository = sussedRepository;
        }
        public int CreateUser(string name)
        {
            return _sussedRepository.CreateUser(name);
        }

        public Question GetQuestion(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAnswer(UserAnswerRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Question GetOtherUserQuestion(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
    
    
}