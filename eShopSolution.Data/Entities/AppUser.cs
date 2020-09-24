using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public string FisrtName { set; get; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public List<Cart> Carts { set; get; }
        public List<Order> Orders { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
