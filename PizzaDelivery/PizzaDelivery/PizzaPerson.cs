using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    public class PizzaPerson
    {
        private string _type { get; set; }
        private string _size { get; set; }
        private string _toppings { get; set; }
        private Customer _customer { get; set; }

        public PizzaPerson(string Type, string Size, string Toppings)
        {
            _type = Type;
            _size = Size;
            _toppings = Toppings;
        }

          
        

    }
}
