namespace Coin.Domain.Entities
{
    public class BasketItem : Entity
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public decimal Price { get; set; }

        public long BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}