namespace Coin.Domain.Identity
{
    public class CosmetologistClient
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long CosmetologistId { get; set; }
        public Cosmetologist Cosmetologist { get; set; }
    }
}