using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class OrderItem : Entity
    {
        public int Quantity { get; set; } = 1;

        public decimal Price { get; set; }

        public bool IsFulfilled { get; set; } = false;

        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long? OrderId { get; set; }

        public Order Order { get; set; }

        public long? BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}