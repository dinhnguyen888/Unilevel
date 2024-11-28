using Unilevel.Models;

public class ImplementationDate
{
    public int Id { get; set; } 
    public DateTime Date { get; set; } 
    public int VisitCalendarId { get; set; } 
    public VisitCalendar VisitCalendar { get; set; }
}
