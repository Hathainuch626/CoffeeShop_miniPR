using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Tables
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
