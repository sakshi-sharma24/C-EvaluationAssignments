using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaDelivery;
namespace OrderDetailsTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomerDetailsCheck()
        {

            Customer customer = new Customer("Sakshi","Sharma",8126558515,"Bareilly");
            Assert.AreEqual("Sakshi", customer.FirstName);
            Assert.AreEqual("Sharma", customer.LastName);
            Assert.AreEqual(8126558515, customer.MobileNumber);
            Assert.AreEqual("Bareilly",customer.Address);
        }
        [TestMethod]
        public void PizzaPersonsDetails()
        {
            Customer customer = new Customer("Sakshi", "Sharma", 8126558515, "Bareilly");
            PizzaPerson pizzaperson = new PizzaPerson("Margareeta","Medium","Extra-Cheese",customer,3,1000);
            Assert.AreEqual("PizzaMania",pizzaperson.Type);
            Assert.AreEqual("Large", pizzaperson.Size);
            Assert.AreEqual("Onions",pizzaperson.Toppings);
            Assert.AreEqual("Sakshi",customer.FirstName);
            Assert.AreEqual(5,pizzaperson.NumbeOfUnits);
            Assert.AreEqual(1500, pizzaperson.Cost);
        }

    

    }
}
