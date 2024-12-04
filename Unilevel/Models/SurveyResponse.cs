namespace Unilevel.Models
{
    public class SurveyResponse
    {
        public string Id { get; set; }
        public int SurveyId { get; set; }    
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public string UserAnswerContent { get; set; }

    }
}
