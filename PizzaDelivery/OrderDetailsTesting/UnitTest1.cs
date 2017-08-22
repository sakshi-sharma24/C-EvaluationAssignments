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
            Assert.AreEqual("Sakshi", customer._firstname);
            Assert.AreEqual("Sharma", customer._lastname);
            Assert.AreEqual(8126558515, customer._mobileNumber);
            Assert.AreEqual("Bareilly",customer._address);
        }
    }
}
