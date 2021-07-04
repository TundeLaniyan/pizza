using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Model;

namespace BlazorApp.Data
{
    public class ShoppingBasketService
    {
        public List<Pizza> ShoppingList = new List<Pizza>();

        public DateTime time = DateTime.Now;

        public double TotalPizzaPrice = 0;

        public bool IsCheckoutComplete = false;

        public bool IsPaid = false;
        //public ShoppingBasketService(ShoppingBasketService item)
        //{
        //    ShoppingList = item.ShoppingList;

        //    TotalPizzaPrice = item.TotalPizzaPrice;

        //    IsCheckoutComplete = item.IsCheckoutComplete;

        //    IsPaid = item.IsPaid;
        //}

        public void getTotal()
        {
            double TotalPriceOfOrder = 0;
            foreach (Pizza pizza in ShoppingList)
            {
                TotalPriceOfOrder += pizza.Price;
            }

            TotalPizzaPrice = TotalPriceOfOrder;
        }

        public List<Pizza> addPizzaToOrder(Pizza Pizza)
        {
            ShoppingList.Add(Pizza);
            getTotal();
            return ShoppingList;
        }
        public List<Pizza> removePizzaToOrder(Pizza Pizza)
        {
           ShoppingList.Remove(Pizza); // removes first occurence
            getTotal();
            return ShoppingList;
        }

        public void clearPizzaBasket()
        {
            ShoppingList.Clear();
            getTotal();
        }

    }
}
