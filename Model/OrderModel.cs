using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Data;

namespace BlazorApp.Model
{
    public class OrderModel
    {
        public ShoppingBasketService OrderDetail { get; set; }
        public Customer CustomerDetail { get; set; }
        public bool Status { get; set; } = true;
        public int _id { get; private set; } = new Random().Next(100000000, 999999999);
    }
}
