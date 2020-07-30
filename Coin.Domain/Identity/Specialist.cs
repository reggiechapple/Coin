using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Specialist : Profile
    {
        public ICollection<SpecialistClient> Clients { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}