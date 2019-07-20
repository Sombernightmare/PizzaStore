namespace PizzaStore.Models
{
    public class OrderItemDetail
    {
        public enum OrderItemDetailType
        {
            Cheese,
            Dough,
            Flavor,
            Sauce,
            Size,
            Topping
        }

        public int ID { get; set; }
        public OrderItemDetailType Type { get; set; }
        //public InventoryItem Item { get; set; }

    }
}