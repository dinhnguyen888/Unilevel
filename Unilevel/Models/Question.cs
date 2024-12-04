namespace Unilevel.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionContent { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsMultipleAnswer { get; set; } = false; // Allow multiple answers
        public bool IsDifferentAnswer { get; set; } = false; // Allow different answers
        public ICollection<Answer> Answers { get; set; }
        public int SurveyId { get; set; } // Foreign key to Survey
        public Survey Survey { get; set; } // Navigation property to Survey
    }
}
