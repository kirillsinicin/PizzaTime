using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurantApp
{
    class Buyer
    {
        private Order order;
        public string Name { get; private set; }

        public Buyer(string name)
        {
            Name = name;
        }

        public void MakeOrder(Restaurant restaurant, PizzaType type)
        {
            Console.WriteLine($"{Name}: I want {type}");
            order = new Order(Name, type);
            order.OnReady += TakePizza;
            restaurant.ProcessOrder(order);
        }

        public void TakePizza(Order order)
        {
            Console.WriteLine($"{Name}: It's mine!");
            order.OnReady -= TakePizza;
        }
    }
}
