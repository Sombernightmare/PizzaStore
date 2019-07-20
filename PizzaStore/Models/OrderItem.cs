using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public enum OrderItemType
    {
        Bread,
        Chicken,
        Drink,
        Pizza,
        Wings,
    }
    public class OrderItem
    {
        public int ID { get; set; }
        public OrderItemType Type { get; set; }
        public decimal Price { get; set; }

        IEnumerable<OrderItemDetail> OrderItemDetails { get; set; }
    }
}
