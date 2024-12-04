namespace Unilevel.Models
{
    public class SurveyRequest
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int SurveyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Survey Survey { get; set; }
        public ICollection<SurveyReceiver> SurveyReceiver { get; set; }   
        
    }
}
