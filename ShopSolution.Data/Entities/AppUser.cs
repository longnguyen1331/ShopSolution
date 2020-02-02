using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Cart> Carts { set; get; }
        public List<Order> Orders { set; get; }
        public List<Transaction> Transactions { set; get; }
    }
}
