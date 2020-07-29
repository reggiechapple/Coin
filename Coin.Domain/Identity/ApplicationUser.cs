using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Coin.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public Administrator Administrator { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}