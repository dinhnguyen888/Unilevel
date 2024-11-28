using System.ComponentModel.DataAnnotations;
namespace Unilevel.Models
{
    public class VisitCalendar
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string CalendarCreatorId { get; set; }
        public User User { get; set; }  
        [Required]
        public string ImplementationTime { get; set; }
        public string  VisitPurpose { get; set; }
        public ICollection<Visitor> Visitors { get; set; } = new List<Visitor>();

        public string DistributorId { get; set; }
        public Distributor Distributor { get; set; }
        
        
        public string? VisitCalendarStatus { get; set; }

        public ICollection<ImplementationDate> ImplementationDates { get; set; } = new List<ImplementationDate>();

    }
}
