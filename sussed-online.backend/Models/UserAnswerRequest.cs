namespace sussed_online.backend.Models
{
    public class UserAnswerRequest
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}