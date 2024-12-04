namespace Unilevel.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string SurveyName { get; set; }
        public string Status { get; set; } //active ; inactive
        public string CreatorId { get; set; }
        public ICollection<Question> Questions { get; set; }

    }
}
