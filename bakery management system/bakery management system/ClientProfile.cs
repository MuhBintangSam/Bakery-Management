using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
    public class ClientProfile
    {
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public Authentication Auth { get; set; }
        public List<Notification> Notifications { get; set; }

        public ClientProfile(int id, string name, string email, string password)
        {
            ClientID = id;
            FullName = name;
            Auth = new Authentication(email, password);
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification note)
        {
            Notifications.Add(note);
        }
    }
}
