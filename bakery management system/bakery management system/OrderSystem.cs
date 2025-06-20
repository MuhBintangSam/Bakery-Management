using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery_management_system
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public List<string> Items { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, int clientId, List<string> items)
        {
            OrderId = orderId;
            ClientId = clientId;
            Items = items;
            OrderDate = DateTime.Now;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Client ID: {ClientId}");
            Console.WriteLine($"Order Date: {OrderDate}");
            Console.WriteLine("Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
