using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    public class Customer
    {
        public string _firstname { get; set; }
        public string _lastname { get; set; }
        public long _mobileNumber { get; set; }
        public string _address { get; set; }

        public Customer(string FirstName,string LastName, long ContactNumber, string Address)
        {
            _firstname = FirstName;
            _lastname = LastName;
            _mobileNumber = ContactNumber;
            _address = Address;
        }
    }
}
