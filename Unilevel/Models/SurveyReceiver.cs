namespace Unilevel.Models
{
    public class SurveyReceiver
    {
        public int SurveyId { get; set; }
        public string SurveyRequestId { get; set; }
        public string UserId { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
