namespace Unilevel.Models
{
    public class NotifyReceiver
    {     
        public string UserId { get; set; }
        public int NotificationId { get; set; }
        public Notification Notification
        {
            get; set;
        }
        }
}
