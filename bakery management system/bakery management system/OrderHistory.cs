using BakeryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery_management_system
{
    public class OrderHistory
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetClientOrders(int clientId)
        {
            return orders.FindAll(o => o.ClientId == clientId);
        }
    }
}






