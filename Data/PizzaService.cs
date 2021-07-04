using System.Collections.Generic;
using BlazorApp.Model;

namespace BlazorApp.Data
{
  public class PizzaService
  {
    public List<Pizza> Pizzas = new List<Pizza>
    {
        new Pizza() { Id = 1, Name = "Hawaiian", Description = "Ham and juicy pineapple on an citrus base", Price = 15.99, Size = "15\"", Image = "hawaiian-pizza.jpg" },
        new Pizza() { Id = 2, Name = "Meat Lover", Description = "As Meaty as it gets on a meat filled base", Price = 19.99, Size = "18\"", Image = "meatlovers-pizza.jpg" },
        new Pizza() { Id = 3, Name = "Breakfast", Description = "The Pizza that will wake you up", Price = 18.99, Size = "18\"", Image = "breakfast-pizza.jpg" },
        new Pizza() { Id = 4, Name = "Mexican", Description = "So tasty and hot, it'll knock you into a siesta", Price = 18.99, Size = "18\"", Image = "mexican-pizza.jpg" },
        new Pizza() { Id = 5, Name = "Rainbow", Description = "Colorful flavours for your tastebuds", Price = 18.99, Size = "18\"", Image = "rainbow-pizza.jpg" },
        new Pizza() { Id = 6, Name = "Fruit", Description = "More than your five a day, vegan friendly", Price = 18.99, Size = "18\"", Image = "fruit-pizza.jpg" }
    };
  }
}
