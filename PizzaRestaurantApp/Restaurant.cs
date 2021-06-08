using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaRestaurantApp
{
    class Restaurant
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Restaurant: Please wait. Processing...");
            MakePizza(order);
        }

        public void MakePizza(Order order)
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Restaurant: {order.BuyerName}, your {order.Type} pizza is ready");
            order.Ready();
        }
    }
}
