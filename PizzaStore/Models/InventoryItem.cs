using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public enum InventoryItemType
    {
        Cheese,
        Dough,
        Flavor,
        Sauce,
        Size,
        Topping
    }
    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int QuantityRemaining { get; set; }

        public decimal PricePerUnit { get; set; }
        public InventoryItemType Type { get; set; }



    }
}
