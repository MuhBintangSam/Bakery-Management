using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery_management_system
{
    public class Feedback
    {
        public int ClientId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // 1 to 5

        public Feedback(int clientId, string comment, int rating)
        {
            ClientId = clientId;
            Comment = comment;
            Rating = rating;
        }

        public void DisplayFeedback()
        {
            Console.WriteLine($"Client ID: {ClientId}");
            Console.WriteLine($"Rating: {Rating}/5");
            Console.WriteLine($"Comment: {Comment}");
        }
    }
}




