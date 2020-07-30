using System.Collections.Generic;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public enum AddressType
    {
        Primary = 10,
        Billing = 20,
        Other = 30
    }

    public class Address : Entity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public AddressType AddressType { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}