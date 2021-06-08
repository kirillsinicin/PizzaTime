using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurantApp
{
    class Order
    {
        public event Action<Order> OnReady;
        public string BuyerName { get; private set; }
        public PizzaType Type { get; private set; }

        public Order(string name, PizzaType type)
        {
            BuyerName = name;
            Type = type;
        }

        public void Ready()
        {
            OnReady(this);
        }
    }
}
