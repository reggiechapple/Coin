using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Customer : Profile
    {
        public Basket Basket { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}