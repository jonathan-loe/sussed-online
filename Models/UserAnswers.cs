using System.Collections.Generic;

namespace sussed_online.backend.Models
{
    public class UserAnswers
    {
        public int UserId { get; set; }
        public IEnumerable<UserAnswer> Answers { get; set; } = new List<UserAnswer>();
    }
}