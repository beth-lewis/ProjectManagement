using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonePalClassLibrary;
using System.Collections.Generic;

namespace PhonePalTest
{
    [TestClass]
    public class tstContractCollection
    {   //create an instance of the class 
        clsContractCollection Contracts = new clsContractCollection();
        [TestMethod]
        public void CountPropertyOK()
        {

            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign data to the property
            Contracts.Count = SomeCount;
            //test to see that it exists
            Assert.AreEqual(Contracts.Count, SomeCount);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create some test to assign to the property
            //in this case the data needs to be a list of objects
            List<clsContracts> TestList = new List<clsContracts>();
            //add an item to the list 
            //create the item of test data
            clsContracts TestItem = new clsContracts();
            //set its properties
            TestItem.ContractNo = 1;
            TestItem.ContractType = "Pay As You Go";
            TestItem.CustomerNo = 1;
            TestItem.ManufacturerNo = 1;
            TestItem.NumberOfMinutes = "600 Mins";
            TestItem.NumberOfTexts = "Unlimited";
            TestItem.PricePerMonth = 30;
            TestItem.StaffNo = 1;
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Duration = "2 Years";
            TestItem.CustomerNo = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Contracts.AllContracts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Contracts.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoContractsPresent()
        {
            //test to see that the two values are the same
            Assert.AreEqual(Contracts.Count, 2);
        }  
    }
}
