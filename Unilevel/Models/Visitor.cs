namespace Unilevel.Models
{
    public class Visitor
    {
        public int VisitCalendarId { get; set; }
        public VisitCalendar VisitCalendar { get; set; }
        public string VisitorId { get; set; }
        public bool IsRefuseInvitation { get; set; } = false;
        public User User { get; set; }
    }
}
