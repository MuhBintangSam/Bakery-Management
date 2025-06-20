using System;
using System.Collections.Generic;

namespace BakeryManagementSystem.Models
{
    public class ShoppingCart
    {
        public int CartId { get; set; }
        public int ClientId { get; set; }
        public List<string> Items { get; set; }

        // Initializes a new shopping cart instance.
        public ShoppingCart(int cartId, int clientId)
        {
            CartId = cartId;
            ClientId = clientId;
            Items = new List<string>();
        }

        // Adds an item to the shopping cart.
        public void AddItem(string item)
        {
            Items.Add(item);
        }

        // Removes an item from the shopping cart.
        public void RemoveItem(string item)
        {
            Items.Remove(item);
        }

        // Displays current shopping cart details to the console.
        public void DisplayCart()
        {
            Console.WriteLine($"Cart ID: {CartId}");
            Console.WriteLine($"Client ID: {ClientId}");
            Console.WriteLine("Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
