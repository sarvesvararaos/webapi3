using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webapi3.Models
{
    public class cnts:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}