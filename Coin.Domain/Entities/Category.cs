using System.Collections.Generic;

namespace Coin.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}