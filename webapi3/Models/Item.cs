using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi3.Models
{
    public class Item
    {
        public int itemId { get; set; }
        public string ItemName { get; set; }
        //public virtual ICollection<Customer> customer { get; set; }
    }
}