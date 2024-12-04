﻿namespace Unilevel.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserCreateNotify { get; set; }
        public string Description { get; set; }
        public ICollection<NotifyReceiver> NotifyReceiver { get; set; }

    }
}
