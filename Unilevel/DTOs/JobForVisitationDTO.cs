using Unilevel.Models;

namespace Unilevel.DTOs
{
    public class JobForVisitationDTO
    {
        public int Id { get; set; }
        public string WorkingPerson { get; set; }
        public string Reporter { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int VisitCalendarId { get; set; }
      
    }
    public class RateTaskDTO
    {
        public int JobId { get; set; }
        public int TaskStar { get; set; }
    }
}
