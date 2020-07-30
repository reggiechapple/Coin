using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Coin.Domain.Entities;

namespace Coin.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public Administrator Administrator { get; set; }
        public Specialist Specialist { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}