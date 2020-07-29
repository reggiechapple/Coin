using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Coin.Domain.Identity;

namespace Coin.Domain.Entities
{
    public class Order : Entity
    {
        [Display(Name = "Your Address")]
        [StringLength(40)]
        [Required(ErrorMessage = "Address must be at least 7 characters long")]
        public string Address { get; set; }

        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        [ScaffoldColumn(false)]
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}