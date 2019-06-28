using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public int itemId { get; set; }
        public virtual Item item { get; set; }
    }
}