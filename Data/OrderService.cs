using BlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class OrderService
    {
        public List<OrderModel> OrderList { get; private set; } = new List<OrderModel>();
        public void AddToActiveOrder(OrderModel activeOrder)
        {
            OrderList.Add(activeOrder);
        }
        public void InactiveAnOrder(OrderModel order)
        {
            var index = OrderList.IndexOf(order);
            OrderList[index].Status = false;
        }
        public OrderModel FindById(string id)
        {
            return OrderList.Find(order => order._id == int.Parse(id));
        }
    }
}
