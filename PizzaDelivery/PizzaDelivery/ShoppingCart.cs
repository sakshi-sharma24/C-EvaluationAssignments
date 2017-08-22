using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    public class ShoppingCart
    {
        List<Customer> customer = new List<Customer>();
        List<PizzaPerson> pizzas = new List<PizzaPerson>();

        public void AddOrderDetails()
        {
            foreach (PizzaPerson p in pizzas)
            {
                pizzas.Add(p);
            }


        }
        public PizzaPerson PlacePerson()
        {
            PizzaPerson item = pizzas[0];
            pizzas[0] = pizzas[1];
            return item;
        }

    }
}
