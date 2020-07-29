using System.Collections.Generic;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class Vendor : Profile
    {
        public string CompanyName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}