namespace sussed_online.backend.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Label { get; set; }
    }
}