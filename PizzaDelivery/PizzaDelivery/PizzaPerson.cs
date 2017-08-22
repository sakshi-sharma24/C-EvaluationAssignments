using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    public class PizzaPerson
    {
        public string Type { get; set; }
        public string  Size { get; set; }
        public string Toppings { get; set; }
        public Customer Customer { get; set; }
        public int NumbeOfUnits { get; set; }
        public int Cost { get; set; }
        public PizzaPerson(string Type, string Size, string Toppings,Customer cus,int units,int price)
        {
            this.Type = Type;
            this.Size = Size;
            this.Toppings = Toppings;
            Customer = cus;
            NumbeOfUnits = units;
            Cost = price;

        }

    }
}
