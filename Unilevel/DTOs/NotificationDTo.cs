namespace Unilevel.DTOs
{
    public class NotificationRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> UserIds { get; set; } // For SendNotificationToUsers
    }
}
