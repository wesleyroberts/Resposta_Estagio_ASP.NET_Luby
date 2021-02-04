using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public class VendingItem
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Double Price { get; set; }

        public VendingItem (int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }  
}
