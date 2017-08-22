using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }

        public Customer(string FirstName,string LastName, long ContactNumber, string Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            MobileNumber = ContactNumber;
            this.Address = Address;
        }
    }
}
