using System;
using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public int ClientId { get; set; }
		public List<string> Items { get; set; }
		public DateTime OrderDate { get; set; }

		// Constructor initializes Order with an order ID, client ID, and list of items.
		public Order(int orderId, int clientId, List<string> items)
		{
			OrderId = orderId;
			ClientId = clientId;
			Items = items;
			OrderDate = DateTime.Now;
		}

		// Displays order details to the console.
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
