using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhonePalTest

{
    [TestClass]

    public class clsCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clss we wnt to create
            clsCustomer ACustomer = new clsCustomer();
            //test to se that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instnc of the clas we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the peroperty
            ACustomer.Active = TestData;
            //test to see that the two values are th same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]

    
    }
}

