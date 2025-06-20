using bakery_management_system;
using BakeryManagementSystem.Models;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        var client = new ClientProfile(1, "Ali", "Ali@gmail.com", "1234");

        var notification = new Notification(1, "Your order has been confirmed!");
        client.AddNotification(notification);

        Console.WriteLine($"Welcome, {client.FullName}");
        foreach (var note in client.Notifications)
        {
            Console.WriteLine($" {note.Message} at {note.Timestamp}");
        }

        var store = new BakeryManagementSystem.Models.StoreLocation("Main Branch", "123 Cake Street", "03-12345678", "main@bakery.com");
        store.DisplayStoreInfo();
    }
}