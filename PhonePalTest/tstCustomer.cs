using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhonePalTest

{
    [TestClass]

    public class clsCustomer
    {
        private bool Active;
        private DateTime DateAdded;
        private int AddressNo;
        private object AnAddress;

        public int CountyNo { get; private set; }

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
            //create an instance of the clas we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the peroperty
            ACustomer.Active = TestData;
            //test to see that the two values are th same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DataAddedPropertyOK()
        {
            //crete an instance of the class we wwant t create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the propety
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //crate an instnce of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.AddressNo = TestData;
            //test to see tht the two values are the same
            Assert.AreEqual(ACustomer.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign th data to te property
            ACustomer.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CountyNo, TestData);

        }
    
    }
}


