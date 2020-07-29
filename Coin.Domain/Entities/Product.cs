using System.Collections.Generic;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class Product : Entity
    {

        public string Name { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public decimal Price { get; set; }

        public bool Avaliable { get; set; }
        public int Stock { get; set; }

        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}