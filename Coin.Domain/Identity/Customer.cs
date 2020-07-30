using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Customer : Profile
    {
        public ICollection<SpecialistClient> Specialists { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}