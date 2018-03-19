using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonePalClassLibrary;
using System.Collections.Generic;

namespace PhonePalTest
{
    [TestClass]
    public class tstContractCollection
    {   //create an instance of the class 
        clsContractCollection AllContracts = new clsContractCollection();
        //create some test data to assign to the property
        List<clsContracts> TestList = new List<clsContracts>();
        //create the item of test data
        clsContracts TestItem = new clsContracts();
        [TestMethod]
        public void CountPropertyOK()
        {

            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign data to the property
            AllContracts.Count = SomeCount;
            //test to see that it exists
            Assert.AreEqual(AllContracts.Count, SomeCount);
        }
        [TestMethod]
        public void ContractListOK()
        {

            TestItem.contractType = "Pay As You Go";
            TestItem.dataAllowance = "5gb";
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.duration = "2 Years";
            TestItem.contractNo = 1;
            TestItem.customerNo = 1;
            TestItem.manufacturerNo = 1;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.ContractList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.ContractList, TestList);
        }
        [TestMethod]
        public void ThisContractPropertyOK()
        {
           
           //create some test data to assign to the property
           clsContracts TestContract = new clsContracts();
           //set the properties of the test object
           TestContract.contractType = "Pay As You Go";
           TestContract.dataAllowance = "5gb";
           TestContract.numberOfMinutes = "600 Mins";
           TestContract.numberOfTexts = "Unlimited";
           TestContract.pricePerMonth = 30;
           TestContract.duration = "2 Years";
           TestContract.contractNo = 1;
           TestContract.customerNo = 1;
           TestContract.manufacturerNo = 1;
           TestContract.staffNo = 1;
           TestContract.startDate = DateTime.Now.Date;
           //assign the data to the property
           AllContracts.ThisContract = TestContract;
           //test to see that the two values are the same
           Assert.AreEqual(AllContracts.ThisContract, TestContract);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an item for the test data
            //here is the test data
            TestItem.contractType = "Pay As You Go";
            TestItem.dataAllowance = "5gb";
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.duration = "2 Years";
            TestItem.contractNo = 1;
            TestItem.customerNo = 1;
            TestItem.manufacturerNo = 1;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.ContractList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, TestList);
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
            TestItem.contractNo = 1;
            TestItem.contractType = "Pay As You Go";
            TestItem.customerNo = 1;
            TestItem.manufacturerNo = 1;
            TestItem.numberOfMinutes = "600 Mins";
            TestItem.numberOfTexts = "Unlimited";
            TestItem.pricePerMonth = 30;
            TestItem.staffNo = 1;
            TestItem.startDate = DateTime.Now.Date;
            TestItem.duration = "2 Years";
            TestItem.customerNo = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllContracts.AllContracts = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, TestList.Count);

        }
        [TestMethod]
        public void TwoContractsPresent()
        {
            //test to see that the two values are the same
            Assert.AreEqual(AllContracts.Count, 2);
        }  
    }
}
