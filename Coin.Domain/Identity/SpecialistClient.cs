namespace Coin.Domain.Identity
{
    public class SpecialistClient
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long SpecialistId { get; set; }
        public Specialist Specialist { get; set; }
    }
}