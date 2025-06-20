using System;

namespace BakeryManagementSystem.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; }

        public Notification(int id, string message)
        {
            NotificationID = id;
            Message = message;
            Timestamp = DateTime.Now;
            IsRead = false;
        }

        public void MarkAsRead()
        {
            IsRead = true;
        }
    }
}
