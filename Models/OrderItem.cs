namespace BookStore.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; } // Order referansı
        public Book Book { get; set; } // Book referansı
        public int Quantity { get; set; }
    }
}
