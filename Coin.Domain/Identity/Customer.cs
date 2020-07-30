using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Customer : Profile
    {
        public ICollection<CosmetologistClient> Cosmetologists { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}