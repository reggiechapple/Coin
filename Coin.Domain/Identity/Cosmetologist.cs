using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Cosmetologist : Profile
    {
        public ICollection<CosmetologistClient> Clients { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}