using System.Collections.Generic;

namespace sussed_online.backend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<Answer> Options { get; set; }
    }
}