namespace Unilevel.Models
{
    public class JobForVisitation
    {
        public int Id { get; set; }
        public string Creator { get; set; }
        public string WorkingPerson { get; set; }
        public string Reporter { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public JobStatuses JobStatus { get; set; }

        public enum JobStatuses
        {
            New,            
            InProgress,    
            Completed ,
            Closed
        }
        public int VisitCalendarId { get; set; }
        public VisitCalendar VisitCalendar { get; set; }
        public JobDetail JobDetail { get; set; }
    }
}
