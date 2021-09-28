using System.Collections.Generic;
using System.Linq;
using sussed_online.backend.Models;

namespace sussed_online.backend.Repository
{
    public class SussedRepository: ISussedRepository
    {
        private static List<User> Users = new List<User>();

        public int CreateUser(string name)
        {
            var user = Users.FirstOrDefault(x => x.Name == name);
            if (user != null)
                return user.Id;

            var newUserId = Users.Count + 1;
            var newUser = new User()
            {
                Id = newUserId,
                Name = name,
                Points = 0
            };
            Users.Add(newUser);
            return newUserId;
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