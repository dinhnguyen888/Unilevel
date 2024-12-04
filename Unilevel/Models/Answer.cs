namespace Unilevel.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; }
        public int QuestionId { get; set; } // Foreign key to Question
        public Question Question { get; set; } // Navigation property to Question
    }
}
