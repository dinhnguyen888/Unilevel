namespace Unilevel.DTOs
{
    public class NotificationRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? AreaId { get; set; }
        public List<string> UserIds { get; set; } // For SendNotificationToUsers
    }

    public class NotificationDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public List<string> Receivers { get; set; }
    }

    public class NotificationResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

}

