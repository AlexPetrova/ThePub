namespace ThePub.Data.Models
{
    public class MealOrders
    {
        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int MealId { get; set; }

        public Meal Meal { get; set; }

        public bool IsDeclined { get; set; }
    }
}
