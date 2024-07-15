using System.Collections.Generic;

namespace BookStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; } // User referansı
        public List<OrderItem> OrderItems { get; set; } // OrderItem referansı
    }
}
