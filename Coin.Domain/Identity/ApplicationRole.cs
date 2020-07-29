using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Coin.Domain.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}