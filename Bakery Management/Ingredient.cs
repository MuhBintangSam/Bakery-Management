using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_Management
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; } 
        public string Unit { get; set; }

        public Ingredient(int ingredientId, string name, int quantity, string unit)
        {
            IngredientID = ingredientId;
            IngredientName = name;
            Quantity = quantity;
            Unit = unit;
        }

        // add stock
        public void AddQuantity(int amount)
        {
            if (amount > 0)
                Quantity += amount;
        }

        // use ingredient
        public bool UseQuantity(int amount)
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
            return $"{IngredientName} (ID: {IngredientID}) - {Quantity} {Unit}";
        }
    }
}
