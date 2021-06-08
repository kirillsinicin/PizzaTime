using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestaurantApp
{
    public enum PizzaType
    {
        Pizza1,
        Pizza2,
        Pizza3,
        Pizza4,
        Pizza5,
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Buyer buyer1 = new Buyer("Viktor");
            Buyer buyer2 = new Buyer("Kirill");
            Buyer buyer3 = new Buyer("Anton");
            Buyer buyer4 = new Buyer("Daria");
            Buyer buyer5 = new Buyer("Katya");

            buyer1.MakeOrder(restaurant, PizzaType.Pizza1);
            //buyer1.MakeOrder(restaurant, PizzaType.Pizza1);
            buyer2.MakeOrder(restaurant, PizzaType.Pizza2);
            buyer3.MakeOrder(restaurant, PizzaType.Pizza3);
            buyer4.MakeOrder(restaurant, PizzaType.Pizza4);
            buyer5.MakeOrder(restaurant, PizzaType.Pizza5);
        }
    }
}
