using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Management
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public byte[] ProductImage { get; set; } 

        public Product(int productId, string productName, decimal price, int quantity, byte[] productImage)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            ProductImage = productImage;
        }

        // for staff
        public void AddStock(int amount)
        {
            if (amount > 0)
                Quantity += amount;
        }

        // for customer
        public bool Purchase(int amount)
        {
            if (amount > 0 && Quantity >= amount)
            {
                Quantity -= amount;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{ProductName} (ID: {ProductID}) - RM{Price:F2} - Stock: {Quantity}";
        }
    }
}

