using System.Collections.Generic;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class Basket : Entity
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}